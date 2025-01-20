﻿using Database_QuizConfigurator.Model;
using Laboration_3.Model;
using MongoDB.Bson;
using System.Collections.ObjectModel;

namespace Laboration_3.ViewModel
{
    internal class QuestionPackViewModel : ViewModelBase
    {
        public QuestionPack model;

        public string Name 
        { 
            get => model.Name;
            set
            {
                model.Name = value;
                RaisePropertyChanged();
            }
        }

        public Difficulty Difficulty
        {
            get => model.Difficulty;
            set
            {
                model.Difficulty = value;
                RaisePropertyChanged();
            }
        }

        public int TimeLimitInSeconds
        {
            get => model.TimeLimitInSeconds;
            set
            {
                model.TimeLimitInSeconds = value;
                RaisePropertyChanged();
            }
        }

        public Category? Category
        {
            get => model.Category;
            set 
            {
                model.Category = value;
                RaisePropertyChanged();
            }
        }

        public ObjectId Id
        {
            get => model.Id; 
            set
            {
                model.Id = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<Question> Questions  
        {
            get => model.Questions;
            set
            {
                model.Questions = value;
                RaisePropertyChanged();
            }
        }

        public QuestionPackViewModel(QuestionPack model)
        {
            this.model = model;
        }

    }
}
