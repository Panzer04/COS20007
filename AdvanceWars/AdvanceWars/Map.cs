using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWars
{
    class Map
    {
        int _rows;
        int _cols;
        int _tileSize;
        Tile[,] _map;
        Tile _selected;
        public Map(int rows, int columns, int tileSize)
        {
            _rows = rows;
            _cols = columns;
            _tileSize = tileSize;
            _map = new Tile[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for(int k = 0; k < columns; k++)
                {
                    Tile tile = new Grassland(i, k, tileSize);
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
                if (t.Selected)
                {
                    
                    t.Draw();
                    SplashKit.FillRectangle(Color.Black, t.Row * t.Size, t.Col * t.Size, t.Size, t.Size);

                }
            }


        }

        /// <summary>
        /// Returns a tile based on the input mouse coordinates
        /// </summary>
        /// <param name="x">Mouse X</param>
        /// <param name="y">Mouse Y</param>
        /// <returns></returns>
        Tile GetTile(int x, int y)
        {
            int row = x / _tileSize;
            int col = y / _tileSize;
            if (row > _rows | col > _cols)
            {
                throw new IndexOutOfRangeException();
            }
            return _map[row, col];
        }

        /// <summary>
        /// Selects a tile based on the input mouse coordinates
        /// </summary>
        /// <param name="x">Mouse X</param>
        /// <param name="y">Mouse Y</param>
        public void Select(int x, int y)
        {
            Tile select = GetTile(x, y);
            foreach (Tile t in _map)
            {
                t.Selected = false;
            }
            select.Selected = !select.Selected;
            _selected = select;
            Console.WriteLine("Click");
        }

        /// <summary>
        /// Move a unit from one tile to another
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(int x, int y)
        {
            if (_selected.Selected)
            {
                if(_selected.Unit is null)
                {
                    Console.WriteLine("No unit!");
                }
                else if(GetTile(x, y) is Tile)
                {
                    if (MoveCost(_selected, GetTile(x, y)) > _selected.Unit.Moves)
                    {
                        Console.WriteLine("Not enough movement! Invalid move command");
                    }
                    GetTile(x, y).Unit = _selected.Unit;
                    _selected.Unit = null;
                }
                else
                {
                    Console.WriteLine("Unit blocking destination");
                }
                
                
            }
        }

        int MoveCost(Tile start, Tile end)
        {
            int startRow = start.Row;
            int startCol = start.Col;
            int moveCost = 0;
            while (startRow < end.Row)
            {
                startRow++;
                moveCost += _map[startRow, startCol].MoveCost;
            }
            while (startRow > end.Row)
            {
                startRow--;
                moveCost += _map[startRow, startCol].MoveCost;
            }

            while (startCol < end.Col)
            {
                startCol++;
                moveCost += _map[startRow, startCol].MoveCost;
            }
            while (startCol > end.Col)
            {
                startCol--;
                moveCost += _map[startRow, startCol].MoveCost;
            }
            return moveCost;
        }

        
        /// <summary>
        /// Iterator that returns each tile in the map
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public Tile this[int row, int col]
        {
            get
            {
                return _map[row, col];
            }
            set
            {
                _map[row, col] = value;
            }
        }

    }
}
