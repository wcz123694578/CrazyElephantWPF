using CrazyElephant.Client.Model;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyElephant.Client.ViewModel
{
    public class DishMenuItemViewModel : BindableBase
    {
        public Dish Dish { get; set; }	// ViewModel里“有一个”Dish的Model

		private bool isSelected;

		public bool IsSelected
		{
			get { return isSelected; }
			set
			{
				isSelected = value;
				this.RaisePropertyChanged("IsSelected");
			}
		}

	}
}
