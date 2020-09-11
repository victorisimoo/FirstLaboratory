using System;
using CustomGenerics.Interface;
using System.Collections.Generic;
using System.Text;


/*
 * author: victorisimoo
 * date: 8-septiembre-2020
 */

namespace CustomGenerics.Structure
{
    public class RangeTree<T> : IStructure<T>
    {

        //Parameters
        private Node<T> root;
        private int orderTree;

        //Constructor Class
        public RangeTree(int order)
        {
            this.orderTree = order;
            this.root = null;
        }

        //Method Insert
        public bool InsertElement(T value, Comparison<T> comparison)
        {
            if (this.root == null)
            {
                this.root = new Node<T>(orderTree);
            }
            return this.root.InsertElement(value, comparison);
        }

        protected override bool Insert(T value, Comparison<T> comparison)
        {
            return InsertElement(value, comparison);
        }
    }
}
