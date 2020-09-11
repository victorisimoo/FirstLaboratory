using System;
using System.Collections.Generic;
using System.Text;

/*
 * author: victorisimoo
 * date: 8-septiembre-2020
 */

namespace CustomGenerics.Structure
{
    public class Node<T>
    {

        //Class parameter
        private Node<T>[] elementArr;
        private T[] valueArr;
        private int orderTree;
        private int cantElements;

        //Class constructor
        public Node(int order)
        {

            this.orderTree = order;
            this.cantElements = 0;

            this.valueArr = new T[order - 1];
            this.elementArr = new Node<T>[order];

            for (int i = 0; i < this.orderTree; i++)
            {
                this.valueArr[i] = default(T);
            }
        }

        //Class constructor
        public Node() { }

        //Method Insert
        public bool InsertElement(T value, Comparison<T> comparison)
        {
            int n = 0;
            for (; n < this.cantElements; n++)
            {
                if (comparison.Invoke(valueArr[n], value) == 0)
                {
                    //Item is duplicated
                    return false;
                }
                else if (comparison.Invoke(valueArr[n], value) > 0)
                {
                    break;
                }
            }
            if (this.cantElements == (this.orderTree - 1))
            {
                if (this.valueArr[n] == null)
                {
                    valueArr[n] = (T)(object)new Node<T>(this.orderTree);
                }
                this.elementArr[n].InsertElement(value, comparison);
            }
            else
            {
                if (n < this.cantElements)
                {
                    for (int j = this.cantElements; j > n; j--)
                    {
                        this.valueArr[j] = this.valueArr[j - 1];
                    }
                }
                this.valueArr[n] = value;
                this.cantElements++;
            }
            return true;
        }

    }
}
