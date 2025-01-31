using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Node<T>
    {
        public T data;
        public List<Node<T>> children;

        public Node(T value)
        {
            data = value;
            children = new List<Node<T>>();
        }
        public Node()
        {
           
        }
    }

    public class GeneralTree<T>
    {
        public Node<T> root;

        public GeneralTree(T value)
        {
            root = new Node<T>(value);
        }

        public void AddChild(Node<T> parent, T value)
        {
            Node<T> child = new Node<T>(value);
            parent.children.Add(child);
        }

        public List<Node<T>> GetChildren(Node<T> parent)
        {
            return parent.children;
        }


        public Node<T> FindNodeByProperty(Node<T> currentNode, string propertyName, object propertyValue)
        {
            if (currentNode == null)
            {
                return null;
            }

            var property = currentNode.data.GetType().GetProperty(propertyName);

            if (property != null && property.GetValue(currentNode.data, null).Equals(propertyValue))
            {
                return currentNode;
            }

            foreach (var child in currentNode.children)
            {
                var result = FindNodeByProperty(child, propertyName, propertyValue);

                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }




        public List<T> LevelOrderTraversal()
        {
            List<T> treeTasks = new List<T>();

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();

                treeTasks.Add(current.data);

                foreach (Node<T> child in current.children)
                {
                    queue.Enqueue(child);
                }
            }

            return treeTasks;
        }



        public List<Node<T>> GetTasksNodes()
        {
            List<Node<T>> firstLevelNodes = new List<Node<T>>();
            if (root == null)
                return firstLevelNodes;

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();
                firstLevelNodes.Add(current);

                foreach (var child in current.children)
                {
                    queue.Enqueue(child);
                }
            }

            return firstLevelNodes;
        }

        public int ChilderNum(Node<T> parent)
        {
            return parent.children.Count;
        }
    }
}
