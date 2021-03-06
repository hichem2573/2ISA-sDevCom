﻿
using ConsumeWebService;
using DevCMetier;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCWinPhone
{
    public class MonitorViewModel : ViewModelBase
    {
        //private ConsumeWSR _cdDAL;
        private ConsumeWSR _cdDAL;
        private ObservableCollection<ViewModelCategorie> _colViewModelCategorie;


        public MonitorViewModel()
        {
            _cdDAL = new ConsumeWSR();
            _colViewModelCategorie = new ObservableCollection<ViewModelCategorie>();

        }

        #region "Propriétés Bindables"

        public ReadOnlyObservableCollection<ViewModelCategorie> Categorie
        {
            get { return new ReadOnlyObservableCollection<ViewModelCategorie>(_colViewModelCategorie); }
        }



        #endregion

        #region "Méthodes"

        public async Task GetCategorie()
        {
            List<Categorie> categories = await _cdDAL.getCategorie();
            MAJ_Categories(categories);
        }

        private void MAJ_Categories(List<Categorie> categories)
        {
            _colViewModelCategorie.Clear();
            foreach (Categorie categorie in categories)
            {
                ViewModelCategorie categorieVM = new ViewModelCategorie(categorie, _cdDAL);

                if (!_colViewModelCategorie.Contains(categorieVM))
                {
                    _colViewModelCategorie.Add(categorieVM);
                }
            }
        }

        #endregion
    }
}
