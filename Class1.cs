using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializationLibrary
{
    public class DataSerializer<T>
    {
        public void SerializeData(T data, string filePath)
        {
            try
            {   
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(fileStream, data);
                    fileStream.Close();
                }
                
                Console.WriteLine("Data serialized successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred during serialization: {ex.Message}");
            }
        }

        public T DeserializeData(string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    T data = (T)serializer.Deserialize(fileStream);
                    Console.WriteLine("Data deserialized successfully.");
                    fileStream.Close();
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred during deserialization: {ex.Message}");
                return default(T);
            }
        }
    }
}

