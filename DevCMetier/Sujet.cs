﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DevCMetier
{
    // On spécifie que le type définit ou implémente un contrat et qu'il est sérialisable
    [DataContract]

    public class Sujet
    {
        #region "Property et Attributs"
        /// <summary>
        /// l'identifiant du sujet
        /// </summary>

        [DataMember]
        private int _Id;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        /// <summary>
        /// La description d'un sujet
        /// </summary>

        [DataMember]
        private string _Desc;

        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        /// <summary>
        /// La date de création du sujet
        /// </summary>

        [DataMember]
        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        /// <summary>
        /// La categorie à la quelle appartient le sujet
        /// </summary>

        [DataMember]
        private Categorie _Categorie;


        public Categorie Categorie
        {
            get { return _Categorie; }
            set { _Categorie = value; }
        }

        /// <summary>
        /// Le Titre du sujet
        /// </summary>

        [DataMember]
        private string _Titre;


        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        /// <summary>
        /// La liste des réponses, concernant un sujet
        /// </summary>

        [DataMember]
        private List<Reponse> _Reponse;


        public List<Reponse> Reponses
        {
            get { return _Reponse; }
            set { _Reponse = value; }
        }

        /// <summary>
        /// L'utilisateur qui a crée et posté la reponse
        /// </summary>

        [DataMember]
        private Utilisateur _Utilisateur;


        public Utilisateur Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }

        /// <summary>
        /// L'auteur de la reponse
        /// </summary>

        [DataMember]
        private string _Auteur;


        public string Auteur
        {
            get { return _Auteur; }
            set { _Auteur = value; }
        }
        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Sujet()
        {

        }
        /// <summary>
        /// Constructeur d'un nouveau sujet, sans reponse
        /// </summary>
        /// <param name="id">L'identifiant du sujet</param>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="categorie">La categorie à la quelle appatient le sujet</param>
        public Sujet(int id, string titre, string description, Categorie categorie)
        {
            this.Id = id;
            this.Titre = titre;
            this.Desc = description;
            this.Categorie = categorie;
            this.Reponses = new List<Reponse>();
            this.Date = DateTime.Now;
        }

        public Sujet(int id, string titre, string description, DateTime date, Utilisateur utilisateur, Categorie categorie) : this(id, titre, description, categorie)
        {
            this.Date = date;
            this.Utilisateur = utilisateur;
            this.Auteur = utilisateur.Login;
        }

        /// <summary>
        /// Constructeur d'un objet sujet, ayant des reponse
        /// </summary>
        /// <param name="id">L'identifiant du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="categorie">La categorie à la quelle appartient le sujet</param>
        /// <param name="Reponses">Les reponses du sujet</param>
        public Sujet(int id, string description, string titre, Categorie categorie, List<Reponse> Reponses) : this(id, titre, description, categorie)
        {
            this.Reponses = Reponses;
        }
        #endregion

        #region "Méthodes"
        public string GetNomUtilisateur()
        {
            return Utilisateur.Login;
        }
        #endregion

        #region "Méthodes héritées et substituées "

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())

            {
                return false;
            }

            Sujet suj = (Sujet)obj;

            return Id == suj.Id;
        }
        #endregion

        #region "Méthodes à implementer pour les interfaces"
        #endregion
    }

}
