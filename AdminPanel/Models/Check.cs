using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace AdminPanel.Models
{
    public class Check
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int CheckSerail { get; set; }

        [StringLength(50)]
        public string CheckTitel { get; set; }

        [StringLength(50)]
        public string CheckType { get; set; }

        public int? Covers { get; set; }

        [StringLength(50)]
        public string MyTable { get; set; }

        [StringLength(50)]
        public string MyStatus { get; set; }

        public bool? Splited { get; set; }

        public long? RefranceTo { get; set; }

        public DateTime? myDateTime { get; set; }

        public DateTime? OpenIn { get; set; }

        public DateTime? ClosedIn { get; set; }

        public string Cust_ID { get; set; }

        public int? Server_ID { get; set; }

        public int? Casher_ID { get; set; }

        public int? Admin_ID { get; set; }

        public int? OutLet_ID { get; set; }

        public int? Rest_ID_Active { get; set; }

        public int? WS { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? Num_Fired { get; set; }

        public int? User_ID { get; set; }

        public bool? Voided { get; set; }

        public DateTime? Voided_Time { get; set; }

        public int? Voided_Reason { get; set; }

        public int? Order_No { get; set; }

        public bool? ReOpen { get; set; }

        public int? Table_ID { get; set; }

        public int? Num_Print { get; set; }

        public int? Lvl_Split { get; set; }

        public int? ChangeAfterSplit { get; set; }

        public bool? Combined { get; set; }

        public long? Combined_To { get; set; }

        public int? ChangeAfterCombine { get; set; }

        public bool? Received { get; set; }

        public DateTime? Received_Time { get; set; }

        public int? Point_ID { get; set; }

        public int? Meal_ID { get; set; }

        public int? Voided_By { get; set; }

        public long? Catering_ID { get; set; }

        public bool? Pick_Up { get; set; }

        public DateTime? Pick_Up_Time { get; set; }

        public bool? Officer { get; set; }

        public int? Officer_ID { get; set; }

        [StringLength(100)]
        public string Void_Reason_Comment { get; set; }

        public bool? Call_Center { get; set; }

        public bool? PrePaid_Card { get; set; }

        [StringLength(20)]
        public string PrePaid_Serial { get; set; }


        public Check()
        {

        }

        public Check(long id, int checkSerail, string checkTitel, string checkType,
             string myStatus, int? outLetId)
        {
            ID = id;
            CheckSerail = checkSerail;
            CheckTitel = checkTitel;
            CheckType = checkType;

            MyStatus = myStatus;
            OutLet_ID = outLetId;
        }

        public Check(long id, int checkSerail, string checkTitel, string checkType, int? covers, string myTable, string myStatus, bool? splited, long? refranceTo, DateTime? myDateTime, DateTime? openIn, DateTime? closedIn, string custId, int? serverId, int? casherId, int? adminId, int? outLetId, int? restIdActive, int? ws, DateTime? date, DateTime? modifiedDate, int? numFired, int? userId, bool? voided, DateTime? voidedTime, int? voidedReason, int? orderNo, bool? reOpen, int? tableId, int? numPrint, int? lvlSplit, int? changeAfterSplit, bool? combined, long? combinedTo, int? changeAfterCombine, bool? received, DateTime? receivedTime, int? pointId, int? mealId, int? voidedBy, long? cateringId, bool? pickUp, DateTime? pickUpTime, bool? officer, int? officerId, string voidReasonComment, bool? callCenter, bool? prePaidCard, string prePaidSerial)
        {
            ID = id;
            CheckSerail = checkSerail;
            CheckTitel = checkTitel;
            CheckType = checkType;
            Covers = covers;
            MyTable = myTable;
            MyStatus = myStatus;
            Splited = splited;
            RefranceTo = refranceTo;
            this.myDateTime = myDateTime;
            OpenIn = openIn;
            ClosedIn = closedIn;
            Cust_ID = custId;
            Server_ID = serverId;
            Casher_ID = casherId;
            Admin_ID = adminId;
            OutLet_ID = outLetId;
            Rest_ID_Active = restIdActive;
            WS = ws;
            CreateDate = date;
            ModifiedDate = modifiedDate;
            Num_Fired = numFired;
            User_ID = userId;
            Voided = voided;
            Voided_Time = voidedTime;
            Voided_Reason = voidedReason;
            Order_No = orderNo;
            ReOpen = reOpen;
            Table_ID = tableId;
            Num_Print = numPrint;
            Lvl_Split = lvlSplit;
            ChangeAfterSplit = changeAfterSplit;
            Combined = combined;
            Combined_To = combinedTo;
            ChangeAfterCombine = changeAfterCombine;
            Received = received;
            Received_Time = receivedTime;
            Point_ID = pointId;
            Meal_ID = mealId;
            Voided_By = voidedBy;
            Catering_ID = cateringId;
            Pick_Up = pickUp;
            Pick_Up_Time = pickUpTime;
            Officer = officer;
            Officer_ID = officerId;
            Void_Reason_Comment = voidReasonComment;
            Call_Center = callCenter;
            PrePaid_Card = prePaidCard;
            PrePaid_Serial = prePaidSerial;
        }
    }

}