using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class House
    {

    public Team Team { get; set; }
    public Basement Basement { get; set; }
    public List<Wall> Walls { get; set; }
    public Door Door { get; set; }
    public List<Window> Windows { get; set; }
    public Roof Roof { get; set; }

        public House(Team team, Basement basement, List<Wall> walls, Door door, List<Window> windows, Roof roof)
        {
            Team = team;
            Basement = basement;
            Walls = walls;
            Door = door;
            Windows = windows;
            Roof = roof;
        }

        public House()
        {
            Walls = new List<Wall>();
            Windows = new List<Window>();

        }

        public void AddWall(Wall wall) { Walls.Add(wall); }
        public void AddWindow(Window window) { Windows.Add(window); }
    }
}
