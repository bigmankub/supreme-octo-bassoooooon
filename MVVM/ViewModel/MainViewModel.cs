using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Model;

namespace MVVM.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> people { get; set; }
        public Person selectedPerson { get; set; }

        public Command SelectPersonCmd { get; }

        public MainViewModel()
        {
            people = new()
            {
                new Person() { Id = 1, Name = "Jan", Surname = "Kowalski"},
                new Person() { Id = 2, Name = "Adam", Surname = "Kaczyński"},
                new Person() { Id = 3, Name = "Anna", Surname = "Nowak"}
            };

            selectedPerson = people[0];
            SelectPersonCmd = new Command<Person>(SelectPerson);

        }

        public void SelectPerson(Person person)
        {
            if (person != null)
                selectedPerson = person;

            OnPropertyChanged(nameof(selectedPerson));
            Application.Current.MainPage.DisplayAlert("Wybrana osoba", $"Witaj, {selectedPerson.Name}!", "OK");
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
