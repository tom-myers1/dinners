using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinners.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }

    public class Catagories
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Catagory
    {
        public int RecipeId { get; set; }
        public int CatagoryId { get; set; }
    }

    public class Ingredient
    {
        public int RecipeId { get; set; }
        public int Line { get; set; }
        public int AmountInt { get; set; }
        public int AmountNum { get; set; }
        public int AmountDenom { get; set; }
        public float Amountfloat { get; set; }
        public string Unit { get; set; }
        public int IngredientId { get; set; }
    }

    public class Ingredients
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class IngredientsSelection
    {
        public int RecipeId { get; set; }
        public int Line { get; set; }
        public string Title { get; set; }
    }

    public class Instruction
    {
        public int RecipeId { get; set; }
        public int Line { get; set; }
        public string Text { get; set; }
    }

    public class InstructionSection
    {
        public int RecipeId { get; set; }
        public int Line { get; set; }
        public string Title { get; set; }
    }

    public class Recipes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Servings { get; set; }
        public string ServingsUnit { get; set; }
    }
}
