using System;
using System.ComponentModel.DataAnnotations;
using AceConstructionCalculator.Attributes;
using AceConstructionCalculator.Enums;

namespace AceConstructionCalculator.Models
{
    public class NewProjectConfigDataForm
    {
        [Display(Prompt = "Project Name", Name = "Project Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter a project name")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [Display(Name = "Total Sqft")]
        public int TotalSquareFootage { get; set; }

        [Display(Name = "Living Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        public int LivingSquareFootage { get; set; }

        [Display(Name = "Amount Of Blocks")]
        [ExpenseAttribute(Expense = Expenses.BLOCK_WORK)]
        public int Blocks { get; set; }

        [Display(Name = "Driveway Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.DRIVEWAY_CONCRETE)]
        public int SquareFootageOfDriveway { get; set; }

        [Display(Name = "Service Walk Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.SERVICE_WALKS)]
        public int SquareFootageOfServiceWalks { get; set; }

        [Display(Name = "Concrete Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.CONCRETE_PATIOS_AND_PORCHES)]
        public int SquareFootageOfConcrete { get; set; }

        [Display(Name = "Garage Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.GARAGE_SLAB)]
        public int SquareFootageOfGarage { get; set; }

        [Display(Name = "Brick Work Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.BRICK)]
        public int SquareFootageOfBrickWork { get; set; }

        [Display(Name = "Stonework Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.STONE)]
        public int SquareFootageOfStoneWork { get; set; }

        [Display(Name = "Stucco Area Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.STUCCO)]
        public int SquareFootageOfStuccoArea { get; set; }

        [Display(Name = "Doors")]
        [ExpenseAttribute(Expense = Expenses.ALL_DOORS)]
        public int AmountOfDoors { get; set; }

        [Display(Name = "Countertops Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.KITCHEN_COUNTERTOPS)]
        public int SquareFootageOfCountertops { get; set; }

        [Display(Name = "Ceramic Tile Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.CERAMIC_TILE)]
        public int SquareFootageOfCeramicTile { get; set; }

        [Display(Name = "Roof Sqft")]
        [Range(1, int.MaxValue, ErrorMessage = "Value Must Be Greater Than 0")]
        [ExpenseAttribute(Expense = Expenses.ROOF_TRUSSES)]
        public int SquareFootageOfRoof { get; set; }
    }
}
