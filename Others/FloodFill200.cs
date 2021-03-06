 using System.Collections.Generic;
 using System.Collections;
 using System;

 namespace AlgorithmPractice {

     //11000
     // 11000
     // 00100
     // 00011
     public class FloodFill {
         private int[, ] direction = { { 0, 1 }, { 1, 0 }, { 0, -1 }, {-1, 0 } };
         private bool[, ] isVisited;
         private long m;
         private long n;
         private void init (char[, ] grid) {
             this.m = grid.GetLongLength (0);
             this.n = grid.GetLongLength (1);
             isVisited = new bool[m, n];
             for (int q = 0; q < m; q++) {
                 for (int p = 0; p < n; p++) {
                     isVisited[q, p] = false;
                 }
             }
         }

         public int NumIslands (char[, ] grid) {
             init (grid);

             int iIsland = 0;
             for (int i = 0; i < m; i++) {
                 for (int j = 0; j < n; j++) {
                     if (grid[i, j] == '1' && !isVisited[i, j]) {
                         Dfs (grid, i, j);
                         iIsland++;
                     }

                 }
             }
             return iIsland;
         }

         private void Dfs (char[, ] grid, int k, int t) {
             isVisited[k, t] = true;
             for (int i = 0; i < 4; i++) {
                 var newk = k + direction[i, 0];
                 var newt = t + direction[i, 1];

                 if (IsInArea (grid, k, t, direction[i, 0], direction[i, 1]) && !isVisited[newk, newk]) {
                     if (grid[newk, newt] == '1') {
                         Dfs (grid, k + newk, newt);
                     }
                 }
             }
         }

         private bool IsInArea (char[, ] grid, int k, int t, int stepX, int stepY) {
             var m = grid.GetLongLength (0);
             var n = grid.GetLongLength (1);

             if (k+stepX >= 0 && k+stepX <m && t+stepY>=0 && t+stepY<n)
                return true;

             return false;
         }
     }
 }