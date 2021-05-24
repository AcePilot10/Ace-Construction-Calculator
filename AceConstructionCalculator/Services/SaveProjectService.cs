using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AceConstructionCalculator.Models;
using Newtonsoft.Json;
using PCLStorage;

namespace AceConstructionCalculator.Services
{
    public class SaveProjectService : ISaveProject
    {
        public async Task<IEnumerable<ProjectResultsModel>> LoadResults()
        {
            string folderName = "projects";
            IFolder folder = FileSystem.Current.LocalStorage;
            folder = await folder.CreateFolderAsync(folderName, CreationCollisionOption.OpenIfExists);
            var files = await folder.GetFilesAsync();
            List<ProjectResultsModel> results = new List<ProjectResultsModel>();
            foreach(var file in files)
            {
                var text = await file.ReadAllTextAsync();
                ProjectResultsModel project = JsonConvert.DeserializeObject<ProjectResultsModel>(text);
                results.Add(project);
            }
            return results;
        }

        // For debugging purposes
        public async void DeleteAll()
        {
            try
            {
                IFolder folder = FileSystem.Current.LocalStorage;
                folder = await folder.GetFolderAsync("projects");
                foreach (var file in await folder.GetFilesAsync())
                {
                    await file.DeleteAsync();
                }
            }
            catch (Exception) { }
        }

        public async Task Save(ProjectResultsModel project)
        {
            string folderName = "projects";
            IFolder folder = FileSystem.Current.LocalStorage;
            folder = await folder.CreateFolderAsync(folderName, CreationCollisionOption.OpenIfExists);
            var file = await folder.CreateFileAsync(project.Id.ToString() + ".json", CreationCollisionOption.ReplaceExisting);
            string json = JsonConvert.SerializeObject(project);
            await file.WriteAllTextAsync(json);
        }

        public async Task DeleteProject(ProjectResultsModel project)
        {
            try
            {
                IFolder folder = await FileSystem.Current.LocalStorage.GetFolderAsync("projects");
                var file = await folder.GetFileAsync(project.Id.ToString() + ".json");
                await file.DeleteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting project file: " + e.Message);
            }
        }
    }
}