using PROG6221_Part3_St10071737.Classes;
using PROG6221_Part3_St10071737.Core;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace PROG6221_Part3_St10071737.MVVM.ViewModel
{
    internal class AddRecipeViewModel : ObservableObject, INotifyPropertyChanged
    {

        private String _ingredientName;

        public string IngredientName
        {
            get { return _ingredientName; }
            set
            {
                _ingredientName = value;
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
                _ingredientName = value;
                OnPropertyChanged(nameof(_selectedFoodGroup));
            }
        }

        private ArrayList _unitFactors;
        //___________________________________________________________________________________________________________

        public ArrayList UnitFactors
        {
            get { return _unitFactors; }
            set { _unitFactors = value; OnPropertyChanged(); }
        }
        //___________________________________________________________________________________________________________

        private ArrayList _Foodgroups;
        //___________________________________________________________________________________________________________

        public ArrayList Foodgroups
        {
            get { return _Foodgroups; }
            set { _Foodgroups = value; OnPropertyChanged(); }
        }
        //___________________________________________________________________________________________________________

        private ObservableCollection<IngredientsClass> _ingredientList;
        //___________________________________________________________________________________________________________

        public ObservableCollection<IngredientsClass> IngredientList
        {
            get { return _ingredientList; }
            set
            {
                _ingredientList = value;
                OnPropertyChanged(nameof(IngredientList));
            }
        }
        //___________________________________________________________________________________________________________

        public ICommand AddIngredientCommand { get; set; }
        //___________________________________________________________________________________________________________

        public AddRecipeViewModel()
        {
            UnitFactors = new ArrayList()
            {
                new IngredientUnitClass() { UoMIndex = 1, UoMName = "Cup(s)  ", UoMValueMl = 250},
                new IngredientUnitClass() { UoMIndex = 2, UoMName = "1/2 Cup(s)", UoMValueMl = 125 },
                new IngredientUnitClass() { UoMIndex = 3, UoMName = "1/4 Cup(s)", UoMValueMl = 62.5},
                new IngredientUnitClass() { UoMIndex = 4, UoMName = "1/8 Cup(s)", UoMValueMl = 31.25},
                new IngredientUnitClass() { UoMIndex = 5, UoMName = "Tablespoon(s)", UoMValueMl = 15},
                new IngredientUnitClass() { UoMIndex = 6, UoMName = "Teaspoon(s)", UoMValueMl = 5},
            };

            Foodgroups = new ArrayList()
            {
                new foodGroupClass(){ FGIndex = 1, FGName = "Protien"},
                new foodGroupClass(){ FGIndex = 2, FGName = "Carboydrates"},
                new foodGroupClass(){ FGIndex = 3, FGName = "Fats"},
                new foodGroupClass(){ FGIndex = 4, FGName = "Dairy"}
            };


            IngredientList = new ObservableCollection<IngredientsClass>();
            AddIngredientCommand = new RelayCommand(AddIngredient);
        }
        //___________________________________________________________________________________________________________

        private void AddIngredient(object obj)
        {
            IngredientsClass ingredients = new IngredientsClass
            {
                IngredientName = IngredientName,
                IngredientQuantity = IngredientQuantity,
                IngredientUoM = SelectedUoM,
                IngredientCalories = IngredientCalories,
                IngredientFoodGroup = IngredientFoodGroup
            };

            IngredientList.Add(ingredients);

            IngredientName = string.Empty;
            IngredientQuantity = 0;
            IngredientCalories = 0;
        }

        //___________________________________________________________________________________________________________

        public event PropertyChangedEventHandler PropertyChanged;
        //___________________________________________________________________________________________________________

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //___________________________________________________________________________________________________________





    }
}
//____________________________________EOF_________________________________________________________________________