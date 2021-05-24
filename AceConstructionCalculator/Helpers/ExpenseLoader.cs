using System;
using AceConstructionCalculator.Enums;
using AceConstructionCalculator.Models;

namespace AceConstructionCalculator.Helpers
{
    public class ExpenseLoader
    {
        #region Site Prep

        public Expense TreeRemovalAndSiteCleaning { get; set; } = new Expense()
        {
            Category = Enums.Categories.SITE_PREP,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 3500,
            Name = "Tree Removal & Site Cleaning",
            ExpenseRef = Expenses.TREE_REMOVAL_AND_SITE_CLEANING
        };

        public Expense Fences { get; set; } = new Expense()
        {
            Category = Enums.Categories.SITE_PREP,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 400,
            Name = "Fencing & Silts",
            ExpenseRef = Expenses.FENCES
        };

        public Expense Excavation { get; set; } = new Expense()
        {
            Category = Enums.Categories.SITE_PREP,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 2500,
            Name = "Excevation",
            ExpenseRef = Expenses.EXCAVATION
        };

        public Expense Gravel { get; set; } = new Expense()
        { 
            Category = Enums.Categories.SITE_PREP,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 200,
            Name = "Gravel",
            CustomPricingMethod = "Loads",
            ExpenseRef = Expenses.GRAVEL
        };

        public Expense TopSoil { get; set; } = new Expense()
        {
            Category = Enums.Categories.SITE_PREP,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 200,
            Name = "Top Soil",
            CustomPricingMethod = "Loads",
            ExpenseRef = Expenses.TOP_SOIL
        };

        public Expense CulvarPipes { get; set; } = new Expense()
        {
            Category = Enums.Categories.SITE_PREP,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 80,
            Name = "Culvar Pipes",
            CustomPricingMethod = "Culvar Pipe Footage",
            ExpenseRef = Expenses.CULVAR_PIPES
        };

        public Expense Grading { get; set; } = new Expense()
        {
            Category = Enums.Categories.SITE_PREP,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 0.30,
            Name = "Grading",
            ExpenseRef = Expenses.GRADING
        };
        #endregion

        #region Concrete / Block Work

        public Expense BlockWork { get; set; } = new Expense()
        {
            Category = Enums.Categories.CONCRETE_AND_BLOCKWORK,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 550,
            Name = "Block Work",
            CustomPricingMethod = "Blocks",
            ExpenseRef = Expenses.BLOCK_WORK
        };

        public Expense ServiceWalks { get; set; } = new Expense()
        {
            Category = Enums.Categories.CONCRETE_AND_BLOCKWORK,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 4.60,
            Name = "Service Walks",
            CustomPricingMethod = "Sqft Of Service Walks",
            ExpenseRef = Expenses.SERVICE_WALKS
        };

        public Expense DrivewayApron { get; set; } = new Expense()
        {
            Category = Enums.Categories.CONCRETE_AND_BLOCKWORK,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 4.50,
            Name = "Driveway Apron",
            CustomPricingMethod = "Sqft Of Driveway",
            ExpenseRef = Expenses.DRIVEWAY_APRON
        };

        public Expense DrivewayConcrete { get; set; } = new Expense()
        {
            Category = Enums.Categories.CONCRETE_AND_BLOCKWORK,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 4.50,
            Name = "Driveway Concrete",
            CustomPricingMethod = "Sqft Of Driveway",
            ExpenseRef = Expenses.DRIVEWAY_CONCRETE
        };

        public Expense FootingAndFoundationWalls { get; set; } = new Expense()
        {
            Category = Enums.Categories.CONCRETE_AND_BLOCKWORK,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 14.50,
            Name = "Footing And Foundation Walls",
            CustomPricingMethod = "Linear Foot Of Concrete",
            ExpenseRef = Expenses.FOOTING_AND_FOUNDATION_WALLS
        };

        public Expense GarageSlab { get; set; } = new Expense()
        {
            Category = Enums.Categories.CONCRETE_AND_BLOCKWORK,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 4.50,
            Name = "Garage Slabs",
            CustomPricingMethod = "Sqft Of Garage",
            ExpenseRef = Expenses.GARAGE_SLAB
        };

        public Expense ConcretePatiosAndPorches { get; set; } = new Expense()
        {
            Category = Enums.Categories.CONCRETE_AND_BLOCKWORK,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 4.50,
            Name = "Concrete Patios & Porches",
            CustomPricingMethod = "Area Of Patio + Porches",
            ExpenseRef = Expenses.CONCRETE_PATIOS_AND_PORCHES
        };

        #endregion

        #region Fascad

        public Expense Brick { get; set; } = new Expense()
        {
            Category = Enums.Categories.FASCAD,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 5,
            Name = "Brick",
            CustomPricingMethod = "Sqft Of Brick Work",
            ExpenseRef = Expenses.BRICK
        };

        public Expense Stone { get; set; } = new Expense()
        {
            Category = Enums.Categories.FASCAD,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 6.50,
            Name = "Stone",
            CustomPricingMethod = "Sqft Of Stone Work",
            ExpenseRef = Expenses.STONE
        };

        public Expense Stucco { get; set; } = new Expense()
        {
            Category = Enums.Categories.FASCAD,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 3.12,
            Name = "Stucco",
            CustomPricingMethod = "Sqft Of Stucco Area",
            ExpenseRef = Expenses.STUCCO
        };

        #endregion

        #region Lumber & Millwork
        public Expense RoofTrusses { get; set; } = new Expense()
        {
            Category = Enums.Categories.LUMBER_AND_MILLWORK,
            PricingMethod = Enums.PricingMethods.LSF,
            Price = 4.91,
            Name = "Roof Trusses",
            ExpenseRef = Expenses.ROOF_TRUSSES
        };

        public Expense FramingLumber { get; set; } = new Expense()
        {
            Category = Enums.Categories.LUMBER_AND_MILLWORK,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 6.50,
            Name = "Framing Lumber",
            ExpenseRef = Expenses.FRAMING_LUMBER
        };

        public Expense InteriorMillwork { get; set; } = new Expense()
        {
            Category = Enums.Categories.LUMBER_AND_MILLWORK,
            PricingMethod = Enums.PricingMethods.LSF,
            Price = 2.81,
            Name = "Interior Millwork",
            ExpenseRef = Expenses.INTERIOR_MILLWORK
        };

        public Expense InteriorTrim { get; set; } = new Expense()
        {
            Category = Enums.Categories.LUMBER_AND_MILLWORK,
            PricingMethod = Enums.PricingMethods.LSF,
            Price = 2.45,
            Name = "Interior Trim",
            ExpenseRef = Expenses.INTERIOR_TRIM
        };
        #endregion

        #region Misc.
        public Expense Carpentry { get; set; } = new Expense()
        {
            Category = Enums.Categories.MISC,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 4.50,
            Name = "General Carpentry",
            ExpenseRef = Expenses.CARPENTRY
        };

        public Expense AllDoors { get; set; } = new Expense()
        {
            Category = Enums.Categories.MISC,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 500,
            Name = "Doors",
            CustomPricingMethod = "Amount Of Doors",
            ExpenseRef = Expenses.ALL_DOORS
        };

        public Expense HVAC { get; set; } = new Expense()
        {
            Category = Enums.Categories.MISC,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 4,
            Name = "HVAC",
            ExpenseRef = Expenses.HVAC
        };

        public Expense Plumbing { get; set; } = new Expense()
        {
            Category = Enums.Categories.MISC,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 3.60,
            Name = "Plumbing",
            ExpenseRef = Expenses.PLUMBING
        };

        public Expense Electric { get; set; } = new Expense()
        {
            Category = Enums.Categories.MISC,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 4,
            Name = "Electric",
            ExpenseRef = Expenses.ELECTRIC
        };

        public Expense Insulation { get; set; } = new Expense()
        {
            Category = Enums.Categories.MISC,
            PricingMethod = Enums.PricingMethods.LSF,
            Price = 1.45,
            Name = "Insulation",
            ExpenseRef = Expenses.INSULATION
        };

        public Expense Drywall { get; set; } = new Expense()
        {
            Category = Enums.Categories.MISC,
            PricingMethod = Enums.PricingMethods.LSF,
            Price = 5.62,
            Name = "Drywall",
            ExpenseRef = Expenses.DRYWALL
        };

        public Expense Painting { get; set; } = new Expense()
        {
            Category = Enums.Categories.MISC,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 2.68,
            Name = "Painting",
            ExpenseRef = Expenses.PAINTING
        };
        #endregion

        #region Kitchen
        public Expense KitchenCabinets { get; set; } = new Expense()
        {
            Category = Enums.Categories.KITCHEN,
            PricingMethod = Enums.PricingMethods.LSF,
            Price = 5.27,
            Name = "Kitchen Cabinets",
            ExpenseRef = Expenses.KITCHEN_CABINETS
        };

        public Expense KitchenCountertops { get; set; } = new Expense()
        {
            Category = Enums.Categories.KITCHEN,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 30,
            Name = "Kitchen Countertops",
            CustomPricingMethod = "Sqft Of Countertops",
            ExpenseRef = Expenses.KITCHEN_COUNTERTOPS
        };

        public Expense KitchenHardware { get; set; } = new Expense()
        {
            Category = Enums.Categories.KITCHEN,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 300,
            Name = "Kitchen Hardware",
            ExpenseRef = Expenses.KITCHEN_HARDWARE
        };
        #endregion

        #region Flooring
        public Expense RegularFlooring { get; set; } = new Expense()
        {
            Category = Enums.Categories.FLOORING,
            PricingMethod = Enums.PricingMethods.LSF,
            Price = 6,
            Name = "Regular Flooring",
            ExpenseRef = Expenses.REGULAR_FLOORING
        };

        public Expense CeramicTile { get; set; } = new Expense()
        {
            Category = Enums.Categories.FLOORING,
            PricingMethod = Enums.PricingMethods.VARIABLE,
            Price = 7,
            Name = "Ceramic Tile",
            CustomPricingMethod = "Sqft Of Ceramic Tile",
            ExpenseRef = Expenses.CERAMIC_TILE
        };
        #endregion

        #region Roofing
        public Expense Shingles { get; set; } = new Expense()
        {
            Category = Enums.Categories.ROOFING,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 4.50,
            Name = "Shingles",
            ExpenseRef = Expenses.SHINGLES
        };

        public Expense Soffits { get; set; } = new Expense()
        {
            Category = Enums.Categories.ROOFING,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 0.54,
            Name = "Soffits",
            ExpenseRef = Expenses.SOFFITS
        };

        public Expense GuttersAndDownspouts { get; set; } = new Expense()
        {
            Category = Enums.Categories.ROOFING,
            PricingMethod = Enums.PricingMethods.TSF,
            Price = 0.72,
            Name = "Gutters & Downspouts",
            ExpenseRef = Expenses.GUTTERS_AND_DOWNSPOUTS
        };
        #endregion

        #region Finishing
        public Expense Lighting { get; set; } = new Expense()
        {
            Category = Enums.Categories.FINISHING,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 800,
            Name = "Lighting",
            ExpenseRef = Expenses.LIGHTING
        };

        public Expense Appliances { get; set; } = new Expense()
        {
            Category = Enums.Categories.FINISHING,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 3500,
            Name = "Appliances",
            ExpenseRef = Expenses.APPLIANCES
        };

        public Expense ShelvingAndHardware { get; set; } = new Expense()
        {
            Category = Enums.Categories.FINISHING,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 1000,
            Name = "Shelving & Hardware",
            ExpenseRef = Expenses.SHELVING_AND_HARDWARE
        };
        #endregion

        #region Cleaning
        public Expense DumpstersAndSanitary { get; set; } = new Expense()
        {
            Category = Enums.Categories.CLEANING,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 1500,
            Name = "Dumpsters & Sanitary",
            ExpenseRef = Expenses.DUMPSTERS_AND_SANITARY
        };

        public Expense CleanOut { get; } = new Expense()
        {
            Category = Enums.Categories.CLEANING,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 600,
            Name = "Cleanout",
            ExpenseRef = Expenses.CLEAN_OUT
        };

        public Expense MiscCleanup { get; } = new Expense()
        {
            Category = Enums.Categories.CLEANING,
            PricingMethod = Enums.PricingMethods.CONSTANT,
            Price = 5000,
            Name = "Misc. / E & O",
            ExpenseRef = Expenses.MISC_CLEANUP
        };
        #endregion
    }
}