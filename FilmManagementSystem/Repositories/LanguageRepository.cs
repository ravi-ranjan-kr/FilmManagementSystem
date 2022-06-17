using FilmManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace FilmManagementSystem.Repositories
{
    public class LanguageRepository
    {
        private readonly FilmManagementSystemContext context;
        public LanguageRepository()
        {
            context = new FilmManagementSystemContext();
        }
        public void AddLanguage(Language language) // add language details
        {
            context.Languages.Add(language);
            context.SaveChanges();
        }
        public List<Language> GetLanguage() // getting all language data
        {
            return context.Languages.ToList();
        }
        public Language GetLanguagebyName(string languagename) // getting language details by language name
        {
            Language language = context.Languages.SingleOrDefault(s => s.LanguageName == languagename);
            return language;
        }
        public void EditLanguage(Language language)// updating or editing data
        {
            context.Languages.Update(language);
            context.SaveChanges();
        }
        public void DeleteLanguage(string id) // deleting data using id
        {
            Language language = context.Languages.Find(id);
            context.Languages.Remove(language);
            context.SaveChanges();
        }
    }
}
