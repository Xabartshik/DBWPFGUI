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
/*
 * Требования
Разделение представления и модели (данных и методов работы с ними).

Одна таблица с 4+ полями === КНИГА ОБИД.

Собственный формат БД или SQL (QSLite или серверная БД)

Добавление, проверка, изменение, удаление данных

Поиск, сортировка (как минимум по одному полю).

Документация (в коде) описывающая формат данных в файле (если используется).

Требования к GUI:

вывод данных в таблицу (но не хранение в этом компоненте!)
меню приложения (menu)
панель инструментов (toolbar)
шрифт и цветовая палитра отличные от задаваемых по умолчанию.
иконка приложения DONE
Всплывающая подсказка или подсказка в строке состояния для элементов интерфейса. ToolTip="Всплывающая подсказка для кнопки"
◦ Информация о разработчике. 
◦ Дополнительно (выполните минимум 3 пункта): 
▪ горячие клавиши +++
▪ цветовое кодирование данных в таблице +++ (если живой, то зеленый, если мертвый, то красный)
▪ использование элементов интерфейса (флажок, числовое поле ввода и тт.п.) в таблице ??? (М.б. в настройках сделать, типа отображения)
▪ хранение изображений в БД ---
▪ использовать как минимум одно модальное окно +++
▪ Автоматическое сохранение БД через заданные интервалы времени +++ 
▪ краткая справка +++
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
namespace DBWPFGUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работает");
        }
    }
}
