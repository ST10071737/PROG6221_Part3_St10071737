using PROG6221_Part3_St10071737.Classes;
using PROG6221_Part3_St10071737.Core;
using PROG6221_Part3_St10071737.MVVM.Model;
using System;
using System.Collections.ObjectModel;

namespace PROG6221_Part3_St10071737.MVVM.ViewModel
{
    public class ViewAllRecipesViewModel : ObservableObject
    {
        private ObservableCollection<RecipeClass> _Recipes { get; set; }
        //___________________________________________________________________________________________________________

        public ObservableCollection<RecipeClass> Recipes
        {
            get { return _Recipes; }
            set
            {
                _Recipes = value;
                OnPropertyChanged(nameof(Recipes));
            }
        }
        //___________________________________________________________________________________________________________

        private RecipeClass _SelectedRecipe;
        //___________________________________________________________________________________________________________

        public RecipeClass SelectedRecipe
        {
            get { return _SelectedRecipe; }
            set
            {
                _SelectedRecipe = value;
                OnPropertyChanged(nameof(SelectedRecipe));
                this.TheseNeedToUpdateApparently();
            }
        }
        //___________________________________________________________________________________________________________

        private string _SelectedRecipeName;
        //___________________________________________________________________________________________________________

        public string SelectedRecipeName
        {
            get { return _SelectedRecipeName; }
            set
            {
                _SelectedRecipeName = value;
                OnPropertyChanged(nameof(SelectedRecipeName));
            }
        }
        //___________________________________________________________________________________________________________

        private double _SelectedRecipeTotalCalories;
        //___________________________________________________________________________________________________________

        public double SelectedRecipeTotalCalories
        {
            get { return _SelectedRecipeTotalCalories; }
            set
            {
                _SelectedRecipeTotalCalories = value;
                OnPropertyChanged(nameof(SelectedRecipeTotalCalories));
            }
        }
        //___________________________________________________________________________________________________________

        private double _SelectedRecipeScale = 1.0;
        //___________________________________________________________________________________________________________

        public double SelectedRecipeScale
        {
            get { return _SelectedRecipeScale; }
            set
            {
                _SelectedRecipeScale = value;
                OnPropertyChanged(nameof(SelectedRecipeScale));
                this.TheseNeedToUpdateApparently();
            }
        }
        //___________________________________________________________________________________________________________

        private string _AllIngredients;
        //___________________________________________________________________________________________________________

        public string AllIngredients
        {
            get { return _AllIngredients; }
            set
            {
                _AllIngredients = value;
                OnPropertyChanged(nameof(AllIngredients));
            }
        }
        //___________________________________________________________________________________________________________

        private string _AllSteps;
        //___________________________________________________________________________________________________________

        public string AllSteps
        {
            get { return _AllSteps; }
            set
            {
                _AllSteps = value;
                OnPropertyChanged(nameof(AllSteps));
            }
        }
        //___________________________________________________________________________________________________________
        private string _IngredientFilter;
        //___________________________________________________________________________________________________________

        public string IngredientFilter
        {
            get { return _IngredientFilter; }
            set
            {
                _IngredientFilter = value;
                OnPropertyChanged(nameof(IngredientFilter));
            }
        }
        //___________________________________________________________________________________________________________

        private string _FoodGroupFilter;
        //___________________________________________________________________________________________________________

        public string FoodGroupFilter
        {
            get { return _FoodGroupFilter; }
            set
            {
                _FoodGroupFilter = value;
                OnPropertyChanged(nameof(FoodGroupFilter));
            }
        }
        //___________________________________________________________________________________________________________

        private double _CaloriesFilter;
        //___________________________________________________________________________________________________________

        public double CaloriesFilter
        {
            get { return _CaloriesFilter; }
            set
            {
                _CaloriesFilter = value;
                OnPropertyChanged(nameof(CaloriesFilter));
            }
        }
        //___________________________________________________________________________________________________________

        public ViewAllRecipesViewModel()
        {
            this.Recipes = new ObservableCollection<RecipeClass>(RecipeListModel.ReturnRecipes());

            SetFilter = new RelayCommand(SearchFilterUpdate);

            RemoveFilter = new RelayCommand(ClearFilter);

            DeleteRecipe = new RelayCommand(Delete);

        }
        //___________________________________________________________________________________________________________

        public void TheseNeedToUpdateApparently()
        {
            if (SelectedRecipe != null)
            {
                RecipeClass scaleRecipe = SelectedRecipe.CreteScaledRecipe(SelectedRecipeScale);

                SelectedRecipeName = scaleRecipe.RecipeName;
                SelectedRecipeTotalCalories = scaleRecipe.TotalCalories();
                AllIngredients = scaleRecipe.PrintIngredients();
                AllSteps = scaleRecipe.PrintSteps();
            }

        }
        //___________________________________________________________________________________________________________
        public void SearchFilterUpdate(Object p)
        {
            var IFilter = this.IngredientFilter;
            var FGFilter = this.FoodGroupFilter;
            var MCFilter = this.CaloriesFilter;

            if (this.Recipes != null)
            {
                var FilteredList = RecipeListModel.ReturnRecipes();

                if (!string.IsNullOrEmpty(IFilter) || !string.IsNullOrEmpty(FGFilter) || MCFilter != 0.0)
                {
                    var filtered = new RecipeFilter(IFilter, FGFilter, MCFilter);
                    FilteredList = filtered.FilteredRecipeList(RecipeListModel.ReturnRecipes());
                }

                Recipes.Clear();
                foreach (var recipe in FilteredList)
                {
                    Recipes.Add(recipe);
                }
            }
        }
        //___________________________________________________________________________________________________________

        public void ClearFilter(Object p)
        {
            this.Recipes = new ObservableCollection<RecipeClass>(RecipeListModel.ReturnRecipes());
        }
        //___________________________________________________________________________________________________________

        public void Delete(object p)
        {
            this.Recipes.Remove(SelectedRecipe);
            this.AllIngredients = string.Empty;
            this.AllSteps = string.Empty;
            this.SelectedRecipeName = string.Empty;
        }

        //___________________________________________________________________________________________________________

        public RelayCommand SetFilter { get; set; }
        //___________________________________________________________________________________________________________

        public RelayCommand RemoveFilter { get; set; }
        //___________________________________________________________________________________________________________

        public RelayCommand DeleteRecipe { get; set; }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________