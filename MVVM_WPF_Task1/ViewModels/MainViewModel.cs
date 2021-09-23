using MVVM_WPF_Task1.Command;
using MVVM_WPF_Task1.Models;
using MVVM_WPF_Task1.Repository;
using MVVM_WPF_Task1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_WPF_Task1.ViewModels
{
    public class MainViewModel
    {
        public Car Car { get; set; }
        public ObservableCollection<Car> Cars { get; set; }
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand EditCommand { get; set; }

        public EditViewModel EditViewModel { get; private set; }

        public MainViewModel()
        {
            Car = new Car
            {
                Id = 1,
                Vendor = "Bmw",
                Model = "M5",
                Year = 2021
            };

            Cars = new FakeRepo().Cars;

            ShowCommand = new RelayCommand(
                act => { MessageBox.Show($"{Car.Vendor} - {Car.Model} - {Car.Year}"); },
                pre => true
                );

            EditCommand = new RelayCommand(
                act =>
                {
                    EditViewModel = new EditViewModel();
                    EditViewModel.Car = Car;


                    var editView = new EditView();
                    editView.DataContext = EditViewModel;
                    EditViewModel.EditView = editView;

                    editView.ShowDialog();
                });

        }
    }
}
