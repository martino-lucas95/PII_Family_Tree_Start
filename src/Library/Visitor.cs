using System;
using System.Text;

namespace Library
{
    public abstract class Visitor
{
    public string Content
    {
        get
        {
            return this.ContentBuilder.ToString();
        }
    }

    protected StringBuilder ContentBuilder { get; } = new StringBuilder();

    public abstract void Node(Node node);

    public abstract void Person(Person person);
