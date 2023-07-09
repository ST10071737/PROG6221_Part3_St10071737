using PROG6221_Part3_St10071737.Classes;
using PROG6221_Part3_St10071737.Core;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace PROG6221_Part3_St10071737.MVVM.ViewModel
{
    internal class AddRecipeViewModel : ObservableObject
    {

        public IngredientsClass ingredientsClass;

        private string _IngredientName = string.Empty;

        public string IngredientName
        {
            get { return _IngredientName; }
            set
            {
                _IngredientName = value;
                OnPropertyChanged(nameof(IngredientName));
            }
        }

        private double _ingredientQuantity;

        public double IngredientQuantity
        {
            get { return _ingredientQuantity; }
            set
            {
                _ingredientQuantity = value;
                OnPropertyChanged(nameof(IngredientQuantity));
            }
        }

        private String _selectedUoM;

        public string SelectedUoM
        {
            get { return _selectedUoM; }
            set
            {
                _selectedUoM = value;
                OnPropertyChanged(nameof(_selectedUoM));
            }
        }

        private double _ingredientCalories;

        public double IngredientCalories
        {
            get { return _ingredientCalories; }
            set
            {
                _ingredientCalories = value;
                OnPropertyChanged(nameof(IngredientCalories));
            }
        }

        private String _selectedFoodGroup;

        public string IngredientFoodGroup
        {
            get { return _selectedFoodGroup; }
            set
            {
                _selectedFoodGroup = value;
                OnPropertyChanged(nameof(_selectedFoodGroup));
            }
        }


        private void test(object param)
        {
            MessageBox.Show(_IngredientName);
            MessageBox.Show(ingredientsClass.IngredientName);
        }

        public AddRecipeViewModel()
        {

            ingredientsClass = new IngredientsClass
            {
                IngredientName = this.IngredientName,
                IngredientQuantity = this.IngredientQuantity,
                IngredientUoM = this.SelectedUoM,
                IngredientCalories = this.IngredientCalories,
                IngredientFoodGroup = this.IngredientFoodGroup,
            };

            TestCommand = new RelayCommand(test);
        }
        //___________________________________________________________________________________________________________

        public RelayCommand TestCommand { get; private set; }

    }
}
//____________________________________EOF_________________________________________________________________________