using PROG6221_Part3_St10071737.Classes;
using PROG6221_Part3_St10071737.Core;
using PROG6221_Part3_St10071737.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_Part3_St10071737.MVVM.ViewModel
{
    public class ViewAllRecipesViewModel : ObservableObject
    {
        private ObservableCollection<RecipeClass> _Recipes { get; set; }

        public ObservableCollection<RecipeClass> Recipes
        {
            get { return _Recipes; }
            set
            {
                _Recipes = value;
                OnPropertyChanged(nameof(Recipes));
            }
        }

        private RecipeClass _SelectedRecipe;

        public RecipeClass SelectedRecipe
        {
            get { return _SelectedRecipe; }
            set
            {
                _SelectedRecipe = value;
                OnPropertyChanged(nameof(SelectedRecipe));
            }
        }

        public ViewAllRecipesViewModel()
        {
            this.Recipes = new ObservableCollection<RecipeClass>(RecipeListModel.ReturnRecipes());
        }
    }
}
