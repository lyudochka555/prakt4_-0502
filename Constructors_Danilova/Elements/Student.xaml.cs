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

namespace Constructors_Danilova.Elements
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Student(Classes.Student student)
        {
            InitializeComponent();
            // В фамилию присваиваем фамилию полученную из Lastname + Firstname + Surname
            tb_fio.Content = student.GetFI0();
            // В степендию присваиваем получает её стедент или нет
            tb_scholarship.Content = student.Scholarship ? "Степендия: получает" : "Степендия:не получает";
            // В курс присваиваем номер курса
            tb_course.Content = $"Курс: {student.Course}";
        }
    }
}
