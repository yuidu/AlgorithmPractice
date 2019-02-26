 using System.Collections.Generic;
 using System.Collections;
 using System;

 namespace AlgorithmPractice {

     //11000
     // 11000
     // 00100
     // 00011
     public class FloodFill {
         private int[, ] direction = { { 1, 0 }, {-1, 0 }, { 0, 1 }, { 0, -1 } };
         private bool[, ] isVisited;
         private long m;
         private long n;
         private void init (char[, ] grid) {
             this.m = grid.GetLongLength (0);
             this.n = grid.GetLongLength (1);
             isVisited = new bool[m, n];
             for (int q = 0; q < m; q++) {
                 for (int p = 0; p < n; p ++) {
                     isVisited[q,p] = false;
                 }
             }
         }

         public int NumIslands (char[, ] grid) {
             init(grid);
             
             int iIsland = 0;
             for (int i = 0; i < m; i++) {
                 for (int j = 0; j < n; j++) {
                     if (grid[i, j] == '1')
                     {
                        Dfs (grid, i, j);
                        iIsland++;
                     }
                         
                 }
             }
             return iIsland;
         }

         private void Dfs (char[, ] grid, int k, int t) {
             for (int i = 0; i < 4; i++) {
                 if (!isVisited[i,t] && IsInArea (grid, k, t, direction[i, 0], direction[i, 1]))
                     Dfs (grid, k + direction[i, 0], t + direction[i, 0]);
             }
         }

         private bool IsInArea (char[, ] grid, int k, int t, int stepX, int stepY) {
             var m = grid.GetLongLength (0);
             var n = grid.GetLongLength (1);

             if (k + stepX > m - 1 || t + stepY > n - 1)
                 return false;

             return true;
         }
     }
 }