using System.Collections.ObjectModel;

namespace basura
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> Colors { get; set; }
        private ObservableCollection<Producto> Productoss { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Colors = new ObservableCollection<string>();
            Productoss = new ObservableCollection<Producto>();
            ColorListView.ItemsSource = Colors;
            ColorPicker.ItemsSource = Colors;
            ProductListView.ItemsSource = Productoss;

        }

        private void OnSubmitColor(object sender, EventArgs e)
        {
            // Get the text from the Entry
            string colorElegido = colorIngresado.Text;

            if (!string.IsNullOrEmpty(colorElegido))
            {

                // Add the entered color to the ObservableCollection
                Colors.Add(colorElegido);

                // Clear the Entry field
                colorIngresado.Text = string.Empty;
            }
        }

        private void OnColorPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the Picker
            string colorSeleccionado = ColorPicker.SelectedItem as string;

            if (!string.IsNullOrEmpty(colorSeleccionado))
            {
                
            }
        }

        private void OnSubmitProducto(object sender, EventArgs e)
        {
            // Get the selected color from the Picker
            string colorSeleccionado = ColorPicker.SelectedItem as string;

            // Get the text from the Entry
            string productoNombre = nombreProducto.Text;

            if (!string.IsNullOrEmpty(productoNombre) && !string.IsNullOrEmpty(colorSeleccionado))
            {
                // Create a new Product and add it to the ObservableCollection
                Productoss.Add(new Producto { Nombre = productoNombre, Color = colorSeleccionado });

                // Clear the Entry field
                nombreProducto.Text = string.Empty;
                ColorPicker.SelectedIndex = -1; // Deselect the Picker
            }
        }


    }

}
