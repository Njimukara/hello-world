using NewHelloWorld.DataModel;
using NewHelloWorld.EntityFramework;

namespace NewHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllMeals();
        }

        private void LoadAllMeals()
        {
            using (var context = new DatabaseContext())
            {
                var allMeals = context.Meals.ToList();
                var mealString = "";

                foreach (var meal in allMeals)
                {
                    mealString += $"Meal Name: {meal.MealName}{Environment.NewLine}Customer: {meal.CustomerName}{Environment.NewLine}{Environment.NewLine}";
                }

                label_Meals.Text = mealString;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            var meal = GetMeal();
            using (var context = new DatabaseContext())
            {
                context.Meals.Add(meal);
                context.SaveChanges();
                LoadAllMeals();
            }
        }

        private Meal GetMeal()
        {
            var meal = new Meal
            {
                MealCost = numericUpDown1.Value,
                MealName = meal_name_input.Text,
                CustomerName = client_name_input.Text,
                CustomerPhone = client_tel_input.Text,
                DateOfMeal = dateTimePicker1.Value
            };
            return meal;
        }
    }
}
