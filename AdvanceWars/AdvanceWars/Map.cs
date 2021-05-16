using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceWars
{
    class Map : IDraw
    {
        int _rows;
        int _cols;
        Tile[,] _map;
        public Map(int rows, int columns)
        {
            _rows = rows;
            _cols = columns;
            _map = new Tile[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for(int k = 0; k < columns; k++)
                {
                    Tile tile = new Grassland(i, k);
                    _map[i, k] = tile;
                }
            }

            //Initialise map tile state. Eventually update to include different tile types or read off a save file
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    
                    
                    
                    if (i == 0)
                    {
                        _map[i, k].Up = null;
                    }
                    else
                    {
                        _map[i, k].Up = _map[i - 1, k];
                    }
                    if(k == 0)
                    {
                        _map[i, k].Left = null;
                    }
                    else
                    {
                        _map[i, k].Left = _map[i, k - 1];
                    }
                    if(k == columns - 1)
                    {
                        _map[i, k].Right = null;
                    }
                    else
                    {
                        _map[i, k].Right = _map[i, k + 1];
                    }
                    if (i == rows - 1)
                    {
                        _map[i, k].Down = null;
                    }
                    else
                    {
                        _map[i, k].Down = _map[i + 1, k];

                    }
                }
            }
        }
        public void Draw()
        {
            foreach (Tile t in _map)
            {
                t.Draw();
            }
        }
    }
}
