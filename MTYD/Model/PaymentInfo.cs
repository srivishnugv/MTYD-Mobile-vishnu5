﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MTYD.Model
{
    public class Item
    {
        public string qty { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string item_uid { get; set; }
        public string itm_business_uid { get; set; }
    }


    public class PaymentInfo
    {
        public string customer_uid { get; set; }
        public string business_uid { get; set; }
        public List<Item> items { get; set; }
        public string salt { get; set; }
        public string delivery_first_name { get; set; }
        public string delivery_last_name { get; set; }
        public string delivery_email { get; set; }
        public string delivery_phone { get; set; }
        public string delivery_address { get; set; }
        public string delivery_unit { get; set; }
        public string delivery_city { get; set; }
        public string delivery_state { get; set; }
        public string delivery_zip { get; set; }
        public string delivery_instructions { get; set; }
        public string delivery_longitude { get; set; }
        public string delivery_latitude { get; set; }
        public string order_instructions { get; set; }
        public string purchase_notes { get; set; }
        public string amount_due { get; set; }
        public string amount_discount { get; set; }
        public string amount_paid { get; set; }
        public string cc_num { get; set; }
        public string cc_exp_year { get; set; }
        public string cc_exp_month { get; set; }
        public string cc_cvv { get; set; }
        public string cc_zip { get; set; }
        /*
        public string customer_uid { get; set; }
        public string business_id { get; set; }
        
        public string salt { get; set; }
        public string delivery_first_name { get; set; }
        public string delivery_last_name { get; set; }
        public string delivery_email { get; set; }
        public string delivery_phone { get; set; }
        public string delivery_address { get; set; }
        public string delivery_unit { get; set; }

        */

        /*
        public string purchase_uid { get; set; }
        public string purchase_date { get; set; }
        public string purchase_id { get; set; }
        public string purchase_status { get; set; }
        public string pur_customer_uid { get; set; }
        public string pur_business_uid { get; set; }
        public List<Item> items { get; set; }
        public string order_instructions { get; set; }
        public string delivery_instructions { get; set; }
        public string order_type { get; set; }
        public string delivery_first_name { get; set; }
        public string delivery_last_name { get; set; }
        public string delivery_phone_num { get; set; }
        public string delivery_email { get; set; }
        public string delivery_address { get; set; }
        public string delivery_unit { get; set; }
        public string delivery_city { get; set; }
        public string delivery_state { get; set; }
        public string delivery_zip { get; set; }
        public string delivery_latitude { get; set; }
        public string delivery_longitude { get; set; }
        public string purchase_notes { get; set; }
        public string payment_uid { get; set; }
        public string payment_id { get; set; }
        public string pay_purchase_id { get; set; }
        public string payment_time_stamp { get; set; }
        public string start_delivery_date { get; set; }
        public string pay_coupon_id { get; set; }
        public double amount_due { get; set; }
        public int amount_discount { get; set; }
        public double amount_paid { get; set; }
        public string info_is_Addon { get; set; }
        public int cc_num { get; set; }
        public string cc_exp_date { get; set; }
        public string cc_cvv { get; set; }
        public string cc_zip { get; set; }
        public string charge_id { get; set; }
        public string payment_type { get; set; }
        public string customer_uid { get; set; }
        public string customer_created_at { get; set; }
        public string customer_first_name { get; set; }
        public string customer_last_name { get; set; }
        public string customer_phone_num { get; set; }
        public string customer_email { get; set; }
        public string customer_address { get; set; }
        public string customer_unit { get; set; }
        public string customer_city { get; set; }
        public string customer_state { get; set; }
        public string customer_zip { get; set; }
        public string customer_lat { get; set; }
        public string customer_long { get; set; }
        public string notification_approval { get; set; }
        public string notification_device_id { get; set; }
        public string customer_rep { get; set; }
        public string SMS_freq_preference { get; set; }
        public string SMS_last_notification { get; set; }
        public string referral_source { get; set; }
        public string role { get; set; }
        public string customer_updated_at { get; set; }
        public string email_verified { get; set; }
        public string user_social_media { get; set; }
        public string user_access_token { get; set; }
        public string user_refresh_token { get; set; }
        */
    }
}
