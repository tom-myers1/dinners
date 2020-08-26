using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinners.Data
{
    public class ProductServices
    {
        #region Private members
        private ProductDbContext dbContext;
        #endregion

        #region Constructor
        public ProductServices(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of ingredients
        /// </summary>

        public async Task<List<Ingredients>> GetIngredientsAsync()
        {
            return await dbContext.Ingredients.ToListAsync();
        }

        public async Task<List<Recipes>> GetRecipesAsync()
        {
            return await dbContext.Recipes.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public async Task<Recipes> AddRecipesAsync(Recipes recipe)
        {
            try
            {
                dbContext.Recipes.Add(recipe);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return recipe;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public async Task<Recipes> UpdateRecipesAsync(Recipes recipe)
        {
            try
            {
                var productExist = dbContext.Recipes.FirstOrDefault(p => p.Id == recipe.Id);
                if (productExist != null)
                {
                    dbContext.Update(recipe);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return recipe;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public async Task DeleteRecipesAsync(Recipes recipe)
        {
            try
            {
                dbContext.Recipes.Remove(recipe);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
