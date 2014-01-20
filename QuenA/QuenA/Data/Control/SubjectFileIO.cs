using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuenA.Data.Control
{
    class SubjectFileIO
    {

        public static void saveSubject(Subject subject, string filePath)
        {
            Stream subjectStream = File.Create(filePath);
            BinaryFormatter serialiser = new BinaryFormatter();
            serialiser.Serialize(subjectStream, subject);
            subjectStream.Close();
        }

        public static Subject loadSubject(string filePath) 
        {
            if (File.Exists(filePath))
            {
                Stream subjectStream = File.OpenRead(filePath);
                BinaryFormatter deserialiser = new BinaryFormatter();
                Subject outputSubject = (Subject)deserialiser.Deserialize(subjectStream);
                subjectStream.Close();
                return outputSubject;
            }
            else 
            {
                return null;
            }
        }
    }
}
