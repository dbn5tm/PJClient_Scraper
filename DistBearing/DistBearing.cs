﻿
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DistBearing
{
 
     /// <summary>
     /// Class providing static methods for calculating with Maidenhead locators, especially
     /// distance and bearing. Based on the Perl script by Dirk Koopman G1TLH from 2002-11-07,
     /// found at http://www.koders.com/perl/fidDAB6FD208AC4F5C0306CA344485FD0899BD2F328.aspx
     /// </summary>
     public class MaidenheadLocator
     {
         /// <summary>
         /// Simple structure to store a position in latitude and longitude
         /// </summary>
         public struct LatLong : IComparable
         {
             /// <summary>
             /// Latitude, -90 to +90 (N/S direction)
             /// </summary>
             public double Lat;
             /// <summary>
             /// Longitude, -180 to +180 (W/E direction)
             /// </summary>
             public double Long;
 
            public override string ToString()
             {
                 return Long.ToString("#.###") + (Long >= 0 ? "N" : "S") + " " + Lat.ToString("#.###") + (Lat >= 0 ? "E" : "W");
             }
 
            public int CompareTo(object to)
             {
                 if (to is LatLong)
                 {
                     if (Lat == ((LatLong) to).Lat && Long == ((LatLong) to).Long) return 0;
                     return -1;
                 }
                 return -1;
             }
         }
 
        /// <summary>
         /// Convert a locator to latitude and longitude in degrees
         /// </summary>
         /// <param name="locator">Locator string to convert</param>
         /// <returns>LatLong structure</returns>
         public static LatLong LocatorToLatLong(string locator)
         {
             locator = locator.Trim().ToUpper();
             if (Regex.IsMatch(locator, "^[A-R]{2}[0-9]{2}[A-X]{2}$"))
             {
                 LatLong ll = new LatLong();
                 ll.Long = (locator[0] - 'A') * 20 + (locator[2] - '0') * 2 + (locator[4] - 'A' + 0.5) / 12 - 180;
                 ll.Lat = (locator[1] - 'A') * 10 + (locator[3] - '0') + (locator[5] - 'A' + 0.5) / 24 - 90;
                 return ll;
             }
             else if (Regex.IsMatch(locator, "^[A-R]{2}[0-9]{2}[A-X]{2}[0-9]{2}$"))
             {
                 LatLong ll = new LatLong();
                 ll.Long = (locator[0] - 'A') * 20 + (locator[2] - '0') * 2 + (locator[4] - 'A' + 0.0) / 12 + (locator[6] - '0' + 0.5) / 120 - 180;
                 ll.Lat = (locator[1] - 'A') * 10 + (locator[3] - '0') + (locator[5] - 'A' + 0.0) / 24 + (locator[7] - '0' + 0.5) / 240 - 90;
                 return ll;
             }
             else if (Regex.IsMatch(locator, "^[A-R]{2}[0-9]{2}[A-X]{2}[0-9]{2}[A-X]{2}$"))
             {
                 LatLong ll = new LatLong();
                 ll.Long = (locator[0] - 'A') * 20 + (locator[2] - '0') * 2 + (locator[4] - 'A' + 0.0) / 12 + (locator[6] - '0' + 0.0) / 120 + (locator[8] - 'A' + 0.5) / 120 / 24 - 180;
                 ll.Lat = (locator[1] - 'A') * 10 + (locator[3] - '0') + (locator[5] - 'A' + 0.0) / 24 + (locator[7] - '0' + 0.0) / 240 + (locator[9] - 'A' + 0.5) / 240 / 24 - 90;
                 return ll;
             }
             else
             {
                 LatLong ll = new LatLong();
                 ll.Lat = 0;
                 ll.Long = 0;
                 return ll;
                 //throw new FormatException("Invalid locator format");
             }
         }
 
        /// <summary>
         /// Convert latitude and longitude in degrees to a locator
         /// </summary>
         /// <param name="ll">LatLong structure to convert</param>
         /// <returns>Locator string</returns>
         public static string LatLongToLocator(LatLong ll)
         {
             return LatLongToLocator(ll.Lat, ll.Long, 0);
         }
 
        /// <summary>
         /// Convert latitude and longitude in degrees to a locator
         /// </summary>
         /// <param name="ll">LatLong structure to convert</param>
         /// <param name="Ext">Extra precision (0, 1, 2)</param>
         /// <returns>Locator string</returns>
         public static string LatLongToLocator(LatLong ll, int Ext)
         {
             return LatLongToLocator(ll.Lat, ll.Long, Ext);
         }
 
        /// <summary>
         /// Convert latitude and longitude in degrees to a locator
         /// </summary>
         /// <param name="Lat">Latitude to convert</param>
         /// <param name="Long">Longitude to convert</param>
         /// <returns>Locator string</returns>
         public static string LatLongToLocator(double Lat, double Long)
         {
             return LatLongToLocator(Lat, Long, 0);
         }
 
        /// <summary>
         /// Convert latitude and longitude in degrees to a locator
         /// </summary>
         /// <param name="Lat">Latitude to convert</param>
         /// <param name="Long">Longitude to convert</param>
         /// <param name="Ext">Extra precision (0, 1, 2)</param>
         /// <returns>Locator string</returns>
         public static string LatLongToLocator(double Lat, double Long, int Ext)
         {
             //int v;
             string locator = "";
 
            Lat += 90;
             Long += 180;
 
            locator += (char) ('A' + Math.Floor(Long / 20));
             locator += (char) ('A' + Math.Floor(Lat / 10));
             Long = Math.IEEERemainder(Long, 20);
             if (Long < 0) Long += 20;
             Lat = Math.IEEERemainder(Lat, 10);
             if (Lat < 0) Lat += 10;
 
            locator += (char) ('0' + Math.Floor(Long / 2));
             locator += (char) ('0' + Math.Floor(Lat / 1));
             Long = Math.IEEERemainder(Long, 2);
             if (Long < 0) Long += 2;
             Lat = Math.IEEERemainder(Lat, 1);
             if (Lat < 0) Lat += 1;
 
            locator += (char) ('A' + Math.Floor(Long * 12));
             locator += (char) ('A' + Math.Floor(Lat * 24));
             Long = Math.IEEERemainder(Long, (double) 1 / 12);
             if (Long < 0) Long += (double) 1 / 12;
             Lat = Math.IEEERemainder(Lat, (double) 1 / 24);
             if (Lat < 0) Lat += (double) 1 / 24;
 
            if (Ext >= 1)
             {
                 locator += (char) ('0' + Math.Floor(Long * 120));
                 locator += (char) ('0' + Math.Floor(Lat * 240));
                 Long = Math.IEEERemainder(Long, (double) 1 / 120);
                 if (Long < 0) Long += (double) 1 / 120;
                 Lat = Math.IEEERemainder(Lat, (double) 1 / 240);
                 if (Lat < 0) Lat += (double) 1 / 240;
             }
 
            if (Ext >= 2)
             {
                 locator += (char) ('A' + Math.Floor(Long * 120 * 24));
                 locator += (char) ('A' + Math.Floor(Lat * 240 * 24));
                 Long = Math.IEEERemainder(Long, (double) 1 / 120 / 24);
                 if (Long < 0) Long += (double) 1 / 120 / 24;
                 Lat = Math.IEEERemainder(Lat, (double) 1 / 240 / 24);
                 if (Lat < 0) Lat += (double) 1 / 240 / 24;
             }
 
            return locator;
             
            //Lat += 90;
             //Long += 180;
             //v = (int) (Long / 20);
             //Long -= v * 20;
             //locator += (char) ('A' + v);
             //v = (int) (Lat / 10);
             //Lat -= v * 10;
             //locator += (char) ('A' + v);
             //locator += ((int) (Long / 2)).ToString();
             //locator += ((int) Lat).ToString();
             //Long -= (int) (Long / 2) * 2;
             //Lat -= (int) Lat;
             //locator += (char) ('A' + Long * 12);
             //locator += (char) ('A' + Lat * 24);
             //return locator;
         }
 
        /// <summary>
         /// Convert radians to degrees
         /// </summary>
         /// <param name="rad"></param>
         /// <returns></returns>
         public static double RadToDeg(double rad)
         {
             return rad / Math.PI * 180;
         }
 
        /// <summary>
         /// Convert degrees to radians
         /// </summary>
         /// <param name="deg"></param>
         /// <returns></returns>
         public static double DegToRad(double deg)
         {
             return deg / 180 * Math.PI;
         }
 
        /// <summary>
         /// Calculate the distance in km between two locators
         /// </summary>
         /// <param name="A">Start locator string</param>
         /// <param name="B">End locator string</param>
         /// <returns>Distance in km</returns>
         public static double Distance(string A, string B)
         {
             return Distance(LocatorToLatLong(A), LocatorToLatLong(B));
         }
 
        /// <summary>
         /// Calculate the distance in km between two locators
         /// </summary>
         /// <param name="A">Start LatLong structure</param>
         /// <param name="B">End LatLong structure</param>
         /// <returns>Distance in km</returns>
         public static double Distance(LatLong A, LatLong B)
         {
             if (A.CompareTo(B) == 0) return 0;
 
            double hn = DegToRad(A.Lat);
             double he = DegToRad(A.Long);
             double n = DegToRad(B.Lat);
             double e = DegToRad(B.Long);
 
            double co = Math.Cos(he - e) * Math.Cos(hn) * Math.Cos(n) + Math.Sin(hn) * Math.Sin(n);
             double ca = Math.Atan(Math.Abs(Math.Sqrt(1 - co * co) / co));
             if (co < 0) ca = Math.PI - ca;
             double dx = 6367 * ca;
 
            return dx;
         }
 
        /// <summary>
         /// Calculate the azimuth in degrees between two locators
         /// </summary>
         /// <param name="A">Start locator string</param>
         /// <param name="B">End locator string</param>
         /// <returns>Azimuth in degrees</returns>
         public static double Azimuth(string A, string B)
         {
             return Azimuth(LocatorToLatLong(A), LocatorToLatLong(B));
         }
 
        /// <summary>
         /// Calculate the azimuth in degrees between two locators
         /// </summary>
         /// <param name="A">Start LatLong structure</param>
         /// <param name="B">End LatLong structure</param>
         /// <returns>Azimuth in degrees</returns>
         public static double Azimuth(LatLong A, LatLong B)
         {
             if (A.CompareTo(B) == 0) return 0;
 
            double hn = DegToRad(A.Lat);
             double he = DegToRad(A.Long);
             double n = DegToRad(B.Lat);
             double e = DegToRad(B.Long);
 
            double co = Math.Cos(he - e) * Math.Cos(hn) * Math.Cos(n) + Math.Sin(hn) * Math.Sin(n);
             double ca = Math.Atan(Math.Abs(Math.Sqrt(1 - co * co) / co));
             if (co < 0) ca = Math.PI - ca;
 
            double si = Math.Sin(e - he) * Math.Cos(n) * Math.Cos(hn);
             co = Math.Sin(n) - Math.Sin(hn) * Math.Cos(ca);
             double az = Math.Atan(Math.Abs(si / co));
             if (co < 0) az = Math.PI - az;
             if (si < 0) az = -az;
             if (az < 0) az = az + 2 * Math.PI;
 
            return RadToDeg(az);
         }
     }
 }

