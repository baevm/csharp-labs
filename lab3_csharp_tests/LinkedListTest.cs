using lab3_csharp;

public class LinkedListTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test] 
    public void Count_Test()
    {
        var ll = new LinkedList();
        
        ll.InsertAtStart(4);
        ll.InsertAtStart(3);
        ll.InsertAtStart(2);
        ll.InsertAtStart(1);

        var expectedCount = 4;
        
        Assert.NotNull(ll.Count);
        Assert.AreEqual(expectedCount, ll.Count);
    }
    
    [Test] 
    public void GetAt_Test()
    {
        var ll = new LinkedList();
        
        ll.InsertAtStart(2);
        ll.InsertAtStart(1);
        
        Assert.AreEqual(ll[2], 2);
        Assert.AreEqual(ll.GetAt(2).val, 2);
    }
    
    [Test] 
    public void InsertAtStart_Test()
    {
        var ll = new LinkedList();
        var expected = 4;
        
        ll.InsertAtStart(expected);
        
        Assert.NotNull(ll.head);
        Assert.AreEqual(ll.head.val, expected);
    }
    
    [Test] 
    public void InsertAt_Test()
    {
        var ll = new LinkedList();
        
        ll.InsertAtStart(4);
        ll.InsertAtStart(3);
        ll.InsertAtStart(2);
        ll.InsertAtStart(1);

        var expectedPos = 2;
        var expectedVal = 10;
        
        ll.InsertAt(expectedPos, expectedVal);
        var inserted = ll[expectedPos];
        Assert.AreEqual(inserted, expectedVal);
    }

    [Test]
    public void InsertAtException_Test()
    {
        var ll = new LinkedList();
        
        ll.InsertAtStart(4);
        ll.InsertAtStart(3);
        ll.InsertAtStart(2);
        ll.InsertAtStart(1);
        
        Assert.Throws<Exception>(() => ll.InsertAt(1000, 1000));
    }
    
    [Test] 
    public void RemoveAt_Test()
    {
        var ll = new LinkedList();
        
        ll.InsertAtStart(4);
        ll.InsertAtStart(3);
        ll.InsertAtStart(2);
        ll.InsertAtStart(1);
        
        ll.PrintList();

        ll.RemoveAt(1);

        var expectedHeadVal = 2;
        
        ll.PrintList();
        
        Assert.AreEqual(ll.head.val, expectedHeadVal);
    }
}
