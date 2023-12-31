﻿using PROG6221_Part3_St10071737.Classes;
using PROG6221_Part3_St10071737.Core;
using PROG6221_Part3_St10071737.MVVM.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace PROG6221_Part3_St10071737.MVVM.ViewModel
{
    public class AddRecipeViewModel : ObservableObject
    {
        //___________________________________________________________________________________________________________
        //________________________________________Ingredients________________________________________________________
        //___________________________________________________________________________________________________________

        private ObservableCollection<IngredientsClass> ingredientsClassList { get; set; } = new ObservableCollection<IngredientsClass>();
        //___________________________________________________________________________________________________________

        private string _IngredientName = string.Empty;
        //___________________________________________________________________________________________________________

        public string IngredientName
        {
            get { return _IngredientName; }
            set
            {
                _IngredientName = value;
                OnPropertyChanged(nameof(IngredientName));
            }
        }
        //___________________________________________________________________________________________________________

        private double _ingredientQuantity;
        //___________________________________________________________________________________________________________

        public double IngredientQuantity
        {
            get { return _ingredientQuantity; }
            set
            {
                _ingredientQuantity = value;
                OnPropertyChanged(nameof(IngredientQuantity));
            }
        }
        //___________________________________________________________________________________________________________

        private String _selectedUoM;
        //___________________________________________________________________________________________________________

        public string SelectedUoM
        {
            get { return _selectedUoM; }
            set
            {
                _selectedUoM = value;
                OnPropertyChanged(nameof(_selectedUoM));
            }
        }
        //___________________________________________________________________________________________________________

        private double _ingredientCalories;
        //___________________________________________________________________________________________________________

        public double IngredientCalories
        {
            get { return _ingredientCalories; }
            set
            {
                _ingredientCalories = value;
                OnPropertyChanged(nameof(IngredientCalories));
            }
        }
        //___________________________________________________________________________________________________________

        private String _selectedFoodGroup;
        //___________________________________________________________________________________________________________

        public string IngredientFoodGroup
        {
            get { return _selectedFoodGroup; }
            set
            {
                _selectedFoodGroup = value;
                OnPropertyChanged(nameof(IngredientFoodGroup));
            }
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //___________________________________________________STEPS___________________________________________________
        //___________________________________________________________________________________________________________

        private ObservableCollection<StepsClass> stepsClassList = new ObservableCollection<StepsClass>();
        //___________________________________________________________________________________________________________

        private String _StepDescription;
        //___________________________________________________________________________________________________________

        public string StepDescription
        {
            get { return _StepDescription; }
            set
            {
                _StepDescription = value;
                OnPropertyChanged(nameof(StepDescription));
            }
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //__________________________________________________Recipe___________________________________________________
        //___________________________________________________________________________________________________________

        public RecipeClass recipeClass { get; set; }
        //___________________________________________________________________________________________________________

        private String _RecipeName;
        //___________________________________________________________________________________________________________

        public string RecipeName
        {
            get { return _RecipeName; }
            set
            {
                _RecipeName = value;
                OnPropertyChanged(nameof(RecipeName));
            }
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //____________________________________________CONSTRUCTOR____________________________________________________
        //___________________________________________________________________________________________________________
        public AddRecipeViewModel()
        {
            AddIngredientCommand = new RelayCommand(AddIngredient);
            AddStepCommand = new RelayCommand(AddStep);
            AddRecipeCommand = new RelayCommand(AddRecipe);
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //______________________________________________COMMANDS_____________________________________________________
        //___________________________________________________________________________________________________________

        public RelayCommand AddIngredientCommand { get; private set; }
        //___________________________________________________________________________________________________________
        public RelayCommand AddStepCommand { get; private set; }
        //___________________________________________________________________________________________________________
        public RelayCommand AddRecipeCommand { get; private set; }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //______________________________________________Methods______________________________________________________
        //___________________________________________________________________________________________________________

        private void AddIngredient(Object p)
        {
            var ingredient = new IngredientsClass
            {
                IngredientName = this.IngredientName,
                IngredientQuantity = this.IngredientQuantity,
                IngredientUoM = this.SelectedUoM,
                IngredientCalories = this.IngredientCalories,
                IngredientFoodGroup = this.IngredientFoodGroup,
            };

            ingredientsClassList.Add(ingredient);

            this.IngredientName = String.Empty;
            this.IngredientQuantity = 0;
            this.SelectedUoM = String.Empty;
            this.IngredientCalories = 0;
            this.IngredientFoodGroup = String.Empty;
        }
        //___________________________________________________________________________________________________________

        private void AddStep(Object p)
        {
            var step = new StepsClass
            {
                StepDescription = this.StepDescription,
            };

            stepsClassList.Add(step);

            this.StepDescription = String.Empty;
        }
        //___________________________________________________________________________________________________________

        private void AddRecipe(Object p)
        {
            var recipe = new RecipeClass
            {
                RecipeName = this.RecipeName,
                IngredientsList = new ObservableCollection<IngredientsClass>(this.ingredientsClassList),
                StepsList = new ObservableCollection<StepsClass>(this.stepsClassList),
            };

            RecipeListModel.AddRecipe(recipe);

            this.RecipeName = String.Empty;
            this.ingredientsClassList.Clear();
            this.stepsClassList.Clear();
            
        }
        //___________________________________________________________________________________________________________

    }
}
//____________________________________EOF__________________________________________________________________________