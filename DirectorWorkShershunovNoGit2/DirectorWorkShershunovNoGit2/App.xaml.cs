using DirectorWorkShershunovNoGit2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DirectorWorkShershunovNoGit2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NaitiKinoEntities DB = new NaitiKinoEntities();
    }
}
