using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsChat
{
    public class Model : INotifyPropertyChanged
    {
        #region Bindings
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

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

        private void FillHistory(List<string> messages)
        {
            if (HisotyMessages == null)
                HisotyMessages = new BindingList<string>();
            HisotyMessages.Clear();

            foreach (var item in messages)
            {
                HisotyMessages.Add(item);
            }
        }

        /// <summary>
        /// пример запроса к сервису
        /// </summary>
        public void RunTest()
        {
            string newMessage = Name + " : " + InputMessage;
            string message = client.Hello(newMessage);

            List<string> messages = new List<string>();
            messages.Add(message);
            FillHistory(messages);
        }

        public void Conncet()
        {

            client = new ServiceReference1.Service1Client();
            client.Open();

            IsConnect = true;


        }
    }
}
