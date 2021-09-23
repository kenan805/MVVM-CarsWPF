using MVVM_WPF_Task1.Command;
using MVVM_WPF_Task1.Models;
using MVVM_WPF_Task1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_WPF_Task1.ViewModels
{
    public class EditViewModel
    {
        public Car Car { get; set; }
        public RelayCommand CloseCommand { get; set; }
        public EditView EditView { get; set; }

        public EditViewModel()
        {
            CloseCommand = new RelayCommand(
                act => {
                    EditView.Close();
                },
                pre => true
                );
        }
    }
}
