using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class likedlist_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer birdSprite;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    public StoreLinkedList options = new StoreLinkedList();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class StoreLinkedList
{
    Node head;
    Node tail;
    int size;

    public StoreLinkedList()
    {

        this.head = new Node(null, 0);
        this.tail = new Node(null, 0);
        this.head.setNext(this.tail);
        this.tail.setPrev(this.head);
        size = 0;
    }

    int getSize()
    {
        return this.size;
    }

    bool add(Sprite Image, int price)// adds at the end of the linkedList
    {

        Node lastNode = new Node(Image, price);
        // The node to add at the end of linkedlist
        Node currLastNode = this.tail.getPrev();
        // The node which is at the end of the linkedlist right now

        lastNode.setNext(this.tail);
        // sets the next of lastNode to the dummy tail
        lastNode.setPrev(currLastNode);
        // sets the prev od lastNode to currLastNode

        currLastNode.setNext(lastNode);
        // sets the next of currLastNode to lastNode
        this.tail.setPrev(lastNode);

        size = size + 1;

        return true; // TODO
    }

    public void set(int index, Sprite data, int price)
    {
        if (data == null)
        {
            throw new System.Exception();
        }

        if (index < 0 || index >= size)
        {
            throw new System.Exception();
        }

        Node currNode = getNth(index);
        
        currNode.setSprite(data);
        currNode.setPrice(price);
    }




    protected class Node
    {
        Node next;
        Node prev;
        int price;
        Sprite Image;

        public Node(Sprite Image, int price)
        {
            this.Image = Image;
            this.price = price;
        }

        public Node(Sprite Image, int price, Node prev, Node next)
        {
            this.Image = Image;
            this.price = price;
            this.prev = prev;
            this.next = next;
        }

        public int getPrice()
        {
            return this.price;
        }

        public void setPrice(int newPrice)
        {
            this.price = newPrice;

        }

        public Sprite getSprite()
        {
            return this.Image;
        }

        public void setSprite(Sprite newImage)
        {
            this.Image = newImage;
        }

        public void setPrev(Node prev)
        {
            this.prev = prev;
        }

        public void setNext(Node next)
        {
            this.next = next;
        }

        public Node getNext()
        {
            return this.next;
        }

        public Node getPrev()
        {
            return this.prev;
        }

    }

    protected Node getNth(int index)
    {

        if (index < 0 || index >= size)
        {
            throw new System.Exception();
        }

        int iterator = 0;
        Node currNode = head.getNext();

        while (iterator < size)
        {
            if (iterator == index)
            {
                return currNode;
            }
            currNode = currNode.getNext();
            iterator = iterator + 1;
        }
        return (Node)null;
    }

    
    /*public Node remove(int index)
    {
        if (index < 0 || index >= size)
        {
            throw new System.Exception();
        }

        Node leftNode, rightNode, currNode;

        currNode = getNth(index);


        if (index == 0)
        {
            leftNode = this.head;// If the node at the beginning is to be removed, leftNode is head
        }
        else
        {
            leftNode = getNth(index - 1);// The node which is the prev of the currNode.
        }

        if (index == size - 1)
        {
            rightNode = this.tail;// If the node at the end is to be removed, rightNode is tail
        }
        else
        {
            rightNode = getNth(index + 1);// The node which is the next of the currNode
        }

        leftNode.setNext(rightNode);
        rightNode.setPrev(leftNode);
        size = size - 1;

        return currNode; // TODO


    }
    */

}

