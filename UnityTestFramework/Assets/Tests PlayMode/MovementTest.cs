using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MovementTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void Moves_Right_Along_X_Axis_For_Horizontal_Input()
    {
        Assert.AreEqual(1, new Movement(1).Calculate(1, 0, 1).x, 0.1f);// Use the Assert class to test conditions
    }

    // A Test behaves as an ordinary method
    [Test]
    public void Moves_Left_Along_X_Axis_For_Horizontal_Input()
    {
        Assert.AreEqual(-1, new Movement(1).Calculate(-1, 0, 1).x, 0.1f);// Use the Assert class to test conditions
    }
    // A Test behaves as an ordinary method
    [Test]
    public void Moves_Up_Along_Y_Axis_For_Vertical_Input()
    {
        Assert.AreEqual(1, new Movement(1).Calculate(0, 1, 1).y, 0.1f);// Use the Assert class to test conditions
    }
    // A Test behaves as an ordinary method
    [Test]
    public void Moves_Down_Along_Y_Axis_For_Vertical_Input()
    {
        Assert.AreEqual(-1, new Movement(1).Calculate(0, -1, 1).y, 0.1f);// Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MovementTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
