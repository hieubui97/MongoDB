using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class DiemSV
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("masv")]
        public string MaSV { get; set; }

        [BsonElement("diemky1")]
        [Range(typeof(float), "0", "100")]
        public float DiemKy1 { get; set; }

        [BsonElement("diemky2")]
        [Range(typeof(float), "0", "100")]
        public float DiemKy2 { get; set; }

        [BsonElement("ketqua")]
        public bool KetQua { get; set; }
    }
}