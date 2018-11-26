using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Xml;

namespace WcfServiceLibraryChat
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        // Код из шаблона проекта
        #region DefaultCode
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        #endregion

        // РБ-софт
        // РБ-Софт пример добавления функционала
        #region RB-Soft

        /// <summary>
        ///  Пример истории
        /// </summary>
        private static List<string> history = new List<string>();

        public string Hello(string message)
        {
            string answer = "you say me " + message;
            history.Add(answer);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in history)
            {
                stringBuilder.AppendLine(item);
            }
            return stringBuilder.ToString();
        }

        #endregion

        public List<string> GetHistory()
        {
            List<string> message = new List<string>();
            List<Message> messageList = new List<Message>();

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Message>));
            try
            {
                using (FileStream fs = new FileStream("MessageHistory.txt", FileMode.OpenOrCreate))
                {
                    messageList = (List<Message>)jsonFormatter.ReadObject(fs);
                    foreach (Message row in messageList)
                    {
                        message.Add(row.text);
                    }
                }
            }
            catch
            {
                message = null;
            }

            //StreamReader reader = new StreamReader(@"MessageHistory.txt");
            //while (!reader.EndOfStream)
            //{
            //    message.Add(reader.ReadLine());
            //}
            //reader.Close();
            return message;
        }

        public void UpdateHistory(string message)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Message>));
            List<Message> messageList = new List<Message>();
            string st = "";

            using (StreamReader fs = new StreamReader("MessageHistory.txt"))
            {
                st = fs.ReadToEnd();
            }

            if (st != "")
                using (FileStream fs = new FileStream("MessageHistory.txt", FileMode.OpenOrCreate))
                {
                    messageList = (List<Message>)jsonFormatter.ReadObject(fs);
                }

            messageList.Add(new Message(message));

            using (Stream stream = new FileStream("MessageHistory.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                jsonFormatter.WriteObject(stream, messageList);
            }
        }
    }
}
