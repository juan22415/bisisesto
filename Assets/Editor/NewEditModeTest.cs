using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewEditModeTest {



	[Test]
	public void Es1948bisiesto() {

		Bisiesto bisiesto = new Bisiesto();

		int year = bisiesto.esbisisesto (1948);

		int yearoperation = year % 4;


		Assert.AreEqual (0, yearoperation);

	}

	[Test]
	public void es1800bisiesto() {

		Bisiesto bisiesto = new Bisiesto();

		int year = bisiesto.esbisisesto (1800);

		int yearoperation = year % 100;


		Assert.AreEqual (0, yearoperation);

	}

	[Test]
	public void Es2000bisiesto() {

		Bisiesto bisiesto = new Bisiesto();

		int year = bisiesto.esbisisesto (2000);

		int yearoperation = year % 400;


		Assert.AreEqual (0, yearoperation);

	}

	}
	
