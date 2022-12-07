using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public class ScientificDocsService
    {
        public static List<ScientificDoc> ScientificDocs = new List<ScientificDoc>
        {
                new ScientificDoc(1, "Документ 1"),
        };

        public IEnumerable<ScientificDoc> GetScientificDocs()
        {
            return ScientificDocs;            
        }

        public void AddScientificDoc(ScientificDoc scientificDoc)
        {
            if (ScientificDocs.Any(x => x.Name == scientificDoc.Name))
                throw new ArgumentException("Such document already exists.");

            int LastId = ScientificDocs.Max(scientificDoc => scientificDoc.Id);
            if (LastId is int)
            {
                scientificDoc.Id = LastId + 1;

                ScientificDocs.Add(scientificDoc);
            }           
        }

        public void UpdateScientificDoc(ScientificDoc scientificDoc)
        {
            var existing = ScientificDocs.FirstOrDefault(x => x.Id == scientificDoc.Id);
            if (existing == null)
                return;
            existing.Name = scientificDoc.Name;
            existing.Result = scientificDoc.Result;
            existing.Location = scientificDoc.Location;
            existing.Note = scientificDoc.Note;         
        }

        public void DeleteScientificDoc(int id)
        {        
            var existing = ScientificDocs.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            ScientificDocs.Remove(existing);
        }
    }
}
