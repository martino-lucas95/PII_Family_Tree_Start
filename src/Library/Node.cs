﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node: Visitor
    {
        private int number;
        private string name;
        private int age;
        private List<Node> children = new List<Node>();

        

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor){
            visitor.Visit(this);
        }
        
    }
}
