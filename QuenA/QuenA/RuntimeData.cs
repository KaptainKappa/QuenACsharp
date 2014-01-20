using QuenA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuenA
{
    static class RuntimeData
    {


        //The subject file currently in use by the application.
        private static Subject currentlyLoadedSubject;

        //The file path where the currently loaded subject was loaded from.
        private static string currentlyLoadedSubjectFilePath;

        //boolean as to whether the currently loaded subject has unsaved changes or not
        private static bool unsavedChanges;

        

        public static Subject CurrentlyLoadedSubject
        {
            get
            {
                return currentlyLoadedSubject;
            }
            set
            {
                currentlyLoadedSubject = value;
            }
        }

        public static string CurrentlyLoadedSubjectFilePath
        {
            get
            {
                return currentlyLoadedSubjectFilePath;
            }
            set
            {
                currentlyLoadedSubjectFilePath = value;
            }
        }

        public static bool UnsavedChanges
        {
            get
            {
                return unsavedChanges;
            }
            set
            {
                unsavedChanges = value;
            }
        }

    }

}