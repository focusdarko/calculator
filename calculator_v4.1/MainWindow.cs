using System;
using Gtk;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

public partial class MainWindow : Gtk.Window
{
	//string ecuacion = "";

	//creating two stacks

	Stack Stack = new Stack();
	Stack ReverseStack = new Stack();

	public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    //Buttons numbers

    private void ButtonClick_1(object sender , EventArgs args)
	{
		ecuacion = ecuacion+"1";
		this.entry5.Text = ecuacion;
	}

	private void ButtonClick_2(object sender, EventArgs args)
    {
		ecuacion = ecuacion + "2";
        this.entry5.Text = ecuacion;
    }

	private void ButtonClick_3(object sender, EventArgs args)
    {
        ecuacion = ecuacion + "3";
        this.entry5.Text = ecuacion;
    }

    private void ButtonClick_4(object sender, EventArgs args)
    {
        ecuacion = ecuacion + "4";
        this.entry5.Text = ecuacion;
    }

	private void ButtonClick_5(object sender, EventArgs args)
    {
        ecuacion = ecuacion + "5";
        this.entry5.Text = ecuacion;
    }

    private void ButtonClick_6(object sender, EventArgs args)
    {
        ecuacion = ecuacion + "6";
        this.entry5.Text = ecuacion;
    }

    private void ButtonClick_7(object sender, EventArgs args)
    {
        ecuacion = ecuacion + "7";
        this.entry5.Text = ecuacion;
    }

    private void ButtonClick_8(object sender, EventArgs args)
    {
        ecuacion = ecuacion + "8";
        this.entry5.Text = ecuacion;
    }

    private void ButtonClick_9(object sender, EventArgs args)
	{
        ecuacion = ecuacion + "9";
        this.entry5.Text = ecuacion;
    }

    private void ButtonClick_0(object sender, EventArgs args)
	{
		ecuacion = ecuacion + "0";
		this.entry5.Text = ecuacion;
	}

	//Operator Buttons

	private void ButtonClick_leftp(object sender, EventArgs args)
	{
		ecuacion = ecuacion + "(";
		this.entry5.Text = ecuacion;
	}

	private void ButtonClick_rightp(object sender, EventArgs args)
	{
		ecuacion = ecuacion + ")";
		this.entry5.Text = ecuacion;
	}

	private void ButtonClick_mul(object sender, EventArgs args)
	{
		ecuacion = ecuacion + "*";
		this.entry5.Text = ecuacion;
	}

	private void ButtonClick_div(object sender, EventArgs args)
	{
		ecuacion = ecuacion + "/";
		this.entry5.Text = ecuacion;
	}

	private void ButtonClick_plu(object sender, EventArgs args)
	{
		ecuacion = ecuacion + "+";
		this.entry5.Text = ecuacion;
	}

	private void ButtonClick_sus(object sender, EventArgs args)
	{
		ecuacion = ecuacion + "-";
		this.entry5.Text = ecuacion;
	}

	/*
    private void ButtonClick_equ(object sender, EventArgs args)
    {

    }

    private void ButtonClick_ans(object sender, EventArgs args)
    {

    }
    */

    //Buttons modes

	private void ButtonClick_ce(object sender, EventArgs args)
    {
        ecuacion = "";
        this.entry5.Text = ecuacion;
    }

    /*
	private void ButtonClick_bi(object sender, EventArgs args)
    {
		ecuacion.ToCharArray();
		int[] binary = new int[1000];
		int CounterBinary = 0;
        while (ecuacion > 0)
		{
			binary[CounterBinary] = ecuacion % 2;
			ecuacion = ecuacion / 2;
			CounterBinary++;
		}
		for (int ResultBinary = CounterBinary - 1; ResultBinary >= 0; ResultBinary--)
			ecuacion = "";
		ecuacion = binary;
    }
*/
}

