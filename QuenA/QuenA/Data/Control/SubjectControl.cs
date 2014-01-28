using QuenA.Data;
using QuenA.Data.Control;
using QuenA.ui;
using RedWards.Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuenA.Data.Control
{
    /// <summary>
    /// Class to handle all commands by the user interface to interact with subjects in some form.
    /// </summary>
    class SubjectControl {

        //instance of the main window of this application.
        private static MainWindow mainWindow;

        //list of all objects observing runtime data in one way or another
        private static List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// Checks if the pointer to the main window is null, and sets it to the current instance of the main window if it is.
        /// </summary>
        private static void refreshMainWindow(){
            if (mainWindow == null)
            {
                mainWindow = Program.MainWindow;
            }
        }

        /// <summary>
        /// Creates a blank subject and loads it into memory, replacing the currently loaded subject.
        /// </summary>
        public static void newSubject() 
        {
            refreshMainWindow();
            Subject blankSubject = new Subject();
            RuntimeData.CurrentlyLoadedSubject = blankSubject;
            RuntimeData.UnsavedChanges = false;
            notify();
        }

        /// <summary>
        /// Loads a subject from the file system and initialises it in the main window.
        /// </summary>
        /// <param name="filePath">The file path of the subject to be loaded.</param>
        public static void loadSubject(string filePath)
        {
            refreshMainWindow();
            Subject subjectToLoad = SubjectFileIO.loadSubject(filePath);
            RuntimeData.CurrentlyLoadedSubject = subjectToLoad;
            RuntimeData.CurrentlyLoadedSubjectFilePath = filePath;
            RuntimeData.UnsavedChanges = false;
            mainWindow.updateSubject();
            notify();
        }

        /// <summary>
        /// Saves a subject to the location it was opened from.
        /// </summary>
        public static void saveSubject() 
        {
            refreshMainWindow();
            if (RuntimeData.CurrentlyLoadedSubjectFilePath != null)
            {
                saveSubject(RuntimeData.CurrentlyLoadedSubjectFilePath);
            }
        }

        /// <summary>
        /// Saves a subject to a specified location in the file system
        /// </summary>
        /// <param name="filePath">The full path of the location of the file to save.</param>
        public static void saveSubject(string filePath)
        {
            refreshMainWindow();
            string[] splitFilePath = filePath.Split('/');
            //get name of file, without path (e.g. "Sofware Engineering.bin")
            string fileName = splitFilePath[splitFilePath.Length - 1];
            //set file name as name of the project
            RuntimeData.CurrentlyLoadedSubject.SubjectName = fileName;

            SubjectFileIO.saveSubject(RuntimeData.CurrentlyLoadedSubject, filePath);
            RuntimeData.UnsavedChanges = false;
            notify();
        }

        /// <summary>
        /// Adds a QuestionCard to the currently loaded subject.
        /// </summary>
        /// <param name="card">The QuestionCard object to add.</param>
        public static void addQuestionCard(QuestionCard card) 
        {
            refreshMainWindow();
            if (mainWindow.addToCardMap(card))
            {
                if (RuntimeData.CurrentlyLoadedSubject.checkForCard(card)) 
                {
                    RuntimeData.CurrentlyLoadedSubject.removeCard(card);
                }
                RuntimeData.CurrentlyLoadedSubject.addCard(card);
                RuntimeData.UnsavedChanges = true;
                notify();
            }
        }

        /// <summary>
        /// Removes a QuestionCard from the currently loaded subject.
        /// </summary>
        /// <param name="card">The QuestionCard object to remove.</param>
        public static void removeQuestionCard(QuestionCard card)
        {
            refreshMainWindow();
            RuntimeData.CurrentlyLoadedSubject.removeCard(card);
            mainWindow.removeFromCardMap(card);
            RuntimeData.UnsavedChanges = true;
            notify();

        }

        /// <summary>
        /// Swaps one question card in the currently loaded subject for another.
        /// </summary>
        /// <param name="card">The QuestionCard object to add.</param>
        public static void changeQuestionCard(QuestionCard oldCard, QuestionCard newCard)
        {
            refreshMainWindow();
            //NB: The methods addQuestionCard() and removeQuestionCard() are not called because this would result in notify() being called twice, slowing the operation down.
            
            //remove the old card from the list.
            RuntimeData.CurrentlyLoadedSubject.removeCard(oldCard);
            mainWindow.removeFromCardMap(oldCard);

            //adds the new card to the list.
            RuntimeData.CurrentlyLoadedSubject.addCard(newCard);
            mainWindow.addToCardMap(newCard);

            RuntimeData.UnsavedChanges = true;
            notify();
        }

        /// <summary>
        /// Make the IObserver passed as a parameter an observer of this object.
        /// </summary>
        /// <param name="obs">The object that wishes to observe this class.</param>
        /// <returns>true if object was successfully attached, false otherwise.</returns>
        public static bool attach(IObserver obs)
        {
            if (observers.Contains(obs))
            {
                return false;
            }
            else
            {
                observers.Add(obs);
                return true;
            }
        }
        /// <summary>
        /// Remove the IObserver object passed as parameter from this class's list of observers.
        /// </summary>
        /// <param name="obs">The object that wishes to no longer observe this class.</param>
        /// <returns>true if object was successfully detached, false otherwise.</returns>
        public static bool detach(IObserver obs)
        {
            if (observers.Contains(obs))
            {
                observers.Remove(obs);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Notifies all observers that an action has been taken by this class and data may have been changed, therefore all observers should update their relevant data. 
        /// </summary>
        private static void notify()
        {
            foreach (IObserver obs in observers)
            {
                obs.update();
            }
        }
    }
}
