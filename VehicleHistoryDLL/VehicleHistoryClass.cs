/* Title:           Vehicle History Dll
 * Date:            4-19-16
 * Author:          Terry Holmes
 *
 * Description:     This Class is the data class for the Vehicle History */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;
using DateSearchDLL;

namespace VehicleHistoryDLL
{
    public class VehicleHistoryClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();
        DateSearchClass TheDataSearchClass = new DateSearchClass();

        //setting up the data variables
        VehicleHistoryDataSet aVehicleHistoryDataSet;
        VehicleHistoryDataSetTableAdapters.vehiclehistoryTableAdapter aVehicleHistoryTableAdapter;

        FindVehicleHistoryByEmployeeIDAndDateRangeDataSet aFindVehicleHistoryByEmployeeIDAndDateRangeDataSet;
        FindVehicleHistoryByEmployeeIDAndDateRangeDataSetTableAdapters.FindVehicleHistoryByEmployeeIDAndDateRangeTableAdapter aFindVehicleHistoryByEmployeeIDAndDateRangeTableAdapter;

        FindVehicleHistoryByVehicleIDAndDateRangeDataSet aFindVehicleHistoryByVehicleIDAndDateRangeDataSet;
        FindVehicleHistoryByVehicleIDAndDateRangeDataSetTableAdapters.FindVehicleHistoryByVehicleIDAndDateRangeTableAdapter aFindVehicleHistoryByVehicleIDAndDateRangeTableAdapter;

        InsertVehicleHistoryEntryTableAdapters.QueriesTableAdapter aInsertVehicleHistoryTableAdapter;

        FindVehicleHistoryCompleteDataSet aFindVehicleHistoryCompleteDataSet;
        FindVehicleHistoryCompleteDataSetTableAdapters.FindVehicleHistoryCompleteTableAdapter aFindVehicleHistoryCompleteTableAdapter;

        FindVehicleHistoryByDateRangeDataSet aFindVehicleHistoryByDateRangeDataSet;
        FindVehicleHistoryByDateRangeDataSetTableAdapters.FindVehicleHistoryByDateRangeTableAdapter aFindVehicleHistoryByDateRangeTableAdapter;

        public FindVehicleHistoryByDateRangeDataSet FindVehicleHistoryByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleHistoryByDateRangeDataSet = new FindVehicleHistoryByDateRangeDataSet();
                aFindVehicleHistoryByDateRangeTableAdapter = new FindVehicleHistoryByDateRangeDataSetTableAdapters.FindVehicleHistoryByDateRangeTableAdapter();
                aFindVehicleHistoryByDateRangeTableAdapter.Fill(aFindVehicleHistoryByDateRangeDataSet.FindVehicleHistoryByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle History Class // Find Vehicle History By Date Range " + Ex.Message);
            }

            return aFindVehicleHistoryByDateRangeDataSet;
        }
        public FindVehicleHistoryCompleteDataSet FindVehicleHistoryComplete(int intVehicleID, int intEmployeeID, int intWarehouseEmployeeID, DateTime datTransactionDate)
        {
            try
            {
                aFindVehicleHistoryCompleteDataSet = new FindVehicleHistoryCompleteDataSet();
                aFindVehicleHistoryCompleteTableAdapter = new FindVehicleHistoryCompleteDataSetTableAdapters.FindVehicleHistoryCompleteTableAdapter();
                aFindVehicleHistoryCompleteTableAdapter.Fill(aFindVehicleHistoryCompleteDataSet.FindVehicleHistoryComplete, intVehicleID, intEmployeeID, intWarehouseEmployeeID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle History Class // Find Vehicle History Complete " + Ex.Message);
            }

            return aFindVehicleHistoryCompleteDataSet;
        }
        public bool InsertVehicleHistory(int intVehicleID, int intEmployeeID, int intWarehouseEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleHistoryTableAdapter = new InsertVehicleHistoryEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleHistoryTableAdapter.InsertVehicleHistory(intVehicleID, intEmployeeID, intWarehouseEmployeeID, DateTime.Now);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle History Class // Insert Vehicle History " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindVehicleHistoryByVehicleIDAndDateRangeDataSet FindVehicleHistoryByVehicleIDAndDateRange(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleHistoryByVehicleIDAndDateRangeDataSet = new FindVehicleHistoryByVehicleIDAndDateRangeDataSet();
                aFindVehicleHistoryByVehicleIDAndDateRangeTableAdapter = new FindVehicleHistoryByVehicleIDAndDateRangeDataSetTableAdapters.FindVehicleHistoryByVehicleIDAndDateRangeTableAdapter();
                aFindVehicleHistoryByVehicleIDAndDateRangeTableAdapter.Fill(aFindVehicleHistoryByVehicleIDAndDateRangeDataSet.FindVehicleHistoryByVehicleIDAndDateRange, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle History Class // Find Vehicle History By Vehicle ID and Date Range " + Convert.ToString(intVehicleID) + " " + Convert.ToString(datStartDate) + " " + Ex.Message);
            }

            return aFindVehicleHistoryByVehicleIDAndDateRangeDataSet;
        }
        public FindVehicleHistoryByEmployeeIDAndDateRangeDataSet FindVehicleHistoryByEmployeeIDAndDateRange(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleHistoryByEmployeeIDAndDateRangeDataSet = new FindVehicleHistoryByEmployeeIDAndDateRangeDataSet();
                aFindVehicleHistoryByEmployeeIDAndDateRangeTableAdapter = new FindVehicleHistoryByEmployeeIDAndDateRangeDataSetTableAdapters.FindVehicleHistoryByEmployeeIDAndDateRangeTableAdapter();
                aFindVehicleHistoryByEmployeeIDAndDateRangeTableAdapter.Fill(aFindVehicleHistoryByEmployeeIDAndDateRangeDataSet.FindVehicleHistoryByEmployeeIDAndDateRange, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle History Class // Find Vehicle History By Employee ID and Date Range " + Ex.Message);
            }

            return aFindVehicleHistoryByEmployeeIDAndDateRangeDataSet;
        }
        public VehicleHistoryDataSet GetVehicleHistoryInfo()
        {
            try
            {
                aVehicleHistoryDataSet = new VehicleHistoryDataSet();
                aVehicleHistoryTableAdapter = new VehicleHistoryDataSetTableAdapters.vehiclehistoryTableAdapter();
                aVehicleHistoryTableAdapter.Fill(aVehicleHistoryDataSet.vehiclehistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle History Class // Get Vehicle History Info " + Ex.Message);
            }

            return aVehicleHistoryDataSet;
        }
        public void UpdateVehicleHistoryDB(VehicleHistoryDataSet aVehicleHistoryDataSet)
        {
            try
            {
                aVehicleHistoryTableAdapter = new VehicleHistoryDataSetTableAdapters.vehiclehistoryTableAdapter();
                aVehicleHistoryTableAdapter.Update(aVehicleHistoryDataSet.vehiclehistory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle History Class // Update Vehicle History DB " + Ex.Message);
            }
        }
    }
}
