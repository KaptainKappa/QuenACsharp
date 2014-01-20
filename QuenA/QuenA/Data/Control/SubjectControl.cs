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
    class SubjectControl {       


        //list of all objects observing runtime data in one way or another
        private static List<IObserver> observers = new List<IObserver>();
        private static MainWindow MainWindow { get { return MainWindow.Instance; } }

        /*
        /// <summary>
        /// Ensures that the mainWindow reference is set to the singleton MainWindow object, and if not set to it, makes it so.
        /// </summary>
        private static void verifyMainWindowNotNull()
        {
            if (MainWindow == null) {
                MainWindow = MainWindow.Instance;
            }
        }
         */

        /// <summary>
        /// Creates a blank subject and loads it into memory, replacing the currently loaded subject.
        /// </summary>
        public static void newSubject() 
        {
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
           //verifyMainWindowNotNull();
            Subject subjectToLoad = SubjectFileIO.loadSubject(filePath);
            RuntimeData.CurrentlyLoadedSubject = subjectToLoad;
            RuntimeData.CurrentlyLoadedSubjectFilePath = filePath;
            RuntimeData.UnsavedChanges = false;
            MainWindow.updateSubject();
            notify();
        }

        public static void saveSubject() 
        {
            if (RuntimeData.CurrentlyLoadedSubjectFilePath != null)
            {
                saveSubject(RuntimeData.CurrentlyLoadedSubjectFilePath);
            }
        }

        public static void saveSubject(string filePath)
        {
            SubjectFileIO.saveSubject(RuntimeData.CurrentlyLoadedSubject, filePath);
            RuntimeData.UnsavedChanges = false;
            notify();
        }

        public static void addQuestionCard(QuestionCard card) 
        {
            //verifyMainWindowNotNull();
            RuntimeData.CurrentlyLoadedSubject.addCard(card);
            MainWindow.addToCardMap(card);
            RuntimeData.UnsavedChanges = true;
            notify();
        }

        public static void removeQuestionCard(QuestionCard card)
        {
            //verifyMainWindowNotNull();
            RuntimeData.CurrentlyLoadedSubject.removeCard(card);
            MainWindow.removeFromCardMap(card);
            RuntimeData.UnsavedChanges = true;
            notify();

        }

        public static void changeQuestionCard(QuestionCard oldCard, QuestionCard newCard)
        {
            //verifyMainWindowNotNull();

            //remove the old card from the list.
            RuntimeData.CurrentlyLoadedSubject.removeCard(oldCard);
            MainWindow.removeFromCardMap(oldCard);

            //adds the new card to the list.
            RuntimeData.CurrentlyLoadedSubject.addCard(newCard);
            MainWindow.addToCardMap(newCard);

            RuntimeData.UnsavedChanges = true;
            notify();
        }

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

        private static void notify()
        {
            foreach (IObserver obs in observers)
            {
                obs.update();
            }
        }
    }
}
