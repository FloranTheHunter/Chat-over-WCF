﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WindowsFormsChat
{
    /// <summary>
    /// Представляет модель клиента чата
    /// </summary>
    public class Model : INotifyPropertyChanged
    {
        #region Bindings

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion Bindings

        private string _serverAddress;
        private int _serverPort;
        private string _name;
        private string _inputMessage;
        private bool _isConncet;

        private ServiceReference1.Service1Client client;

        public bool IsConnect
        {
            get => _isConncet;
            set
            {
                _isConncet = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<string> HisotyMessages { get; set; }

        public string ServerAddress
        {
            get => _serverAddress;
            set
            {
                _serverAddress = value;
                NotifyPropertyChanged();
            }
        }

        public int ServerPort
        {
            get => _serverPort;
            set
            {
                _serverPort = value; NotifyPropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        public string InputMessage
        {
            get => _inputMessage;
            set
            {
                _inputMessage = value;
                NotifyPropertyChanged();
            }
        }

        public Model()
        {
            InitDefault();
            HisotyMessages = new BindingList<string>();
        }

        /// <summary>
        /// Инициализация данных по умолчанию
        /// </summary>
        private void InitDefault()
        {
            ServerPort = 8733;
            ServerAddress = "localhost";
            Name = "Марк Цукерберг";
        }

        /// <summary>
        /// Заполнить историю
        /// </summary>
        /// <param name="messages">The messages.</param>
        private void FillHistory(List<string> messages)
        {
            HisotyMessages.Clear();

            foreach (var item in messages)
            {
                HisotyMessages.Add(item);
            }
        }

        /// <summary>
        /// Пример отправки сообщения к сервису  и получение ответа от него
        /// </summary>
        public void RunTest()
        {
            string newMessage = Name + " : " + InputMessage + " " + DateTime.Now.ToString();
            string message = client.Hello(newMessage);

            List<string> messages = new List<string>();
            messages.Add(message);
            FillHistory(messages);
        }

        public void Conncet()
        {
            string endpointAddress = $"http://{ServerAddress}:{ServerPort}/Design_Time_Addresses/WcfServiceLibraryChat/Service1/";
            client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1", endpointAddress);
            client.Open();
            IsConnect = true;
        }

        /// <summary>
        /// Отправка сообщения на сервер
        /// </summary>
        public void SendMessage()
        {
            string newMessage = Name + " : " + InputMessage;

            //TODO вызвать отправку сообщения на сервер
            // примерно как здесь
            // client.SendMessage(newMessage);

            System.Windows.Forms.MessageBox.Show("Заглушка отправки сообщения. Сообщение " + newMessage);

            List<string> messages = GetHistoryMessages();
            FillHistory(messages);
        }

        /// <summary>
        /// Запрос истории сообщений с сервера
        /// </summary>
        /// <returns></returns>
        public List<string> GetHistoryMessages()
        {
            // TODO реализовать запрос с сообщениями
            // примерно как здесь
            // List<string> messages = client.GetHistory();

            // заглушка истории сообщений
            List<string> messages = new List<string>();
            System.Windows.Forms.MessageBox.Show("Заглушка запроса истории сообщений");
            messages.Add($"{DateTime.Now.ToShortTimeString()} пользователь1 : Привет");
            messages.Add($"{DateTime.Now.ToLongTimeString()} пользователь2 : Привет, как дела)");
            messages.Add($"{DateTime.Now.ToShortTimeString()} пользователь1 : Ты робот?");
            messages.Add($"{DateTime.Now.ToShortTimeString()} пользователь2 : Почти...");

            return messages;
        }
    }
}