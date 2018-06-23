using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Labirint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
 
            // Создаем генератор лабиринта.
            MazeGame game = new MazeGame();

            MazeFactory factory = new MazeFactory();
           //Конфигурируем фабрику базовыми элементами лабиринта
           MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory( new Maze(), new Wall(), new Room(2), new Door());
          
            // Создаем лабиринт из двух комнат используя фабричный метод - CreateMaze().
            Maze maze = game.CreateMaze(simpleMazeFactory);
           

        }
        

    }
}
