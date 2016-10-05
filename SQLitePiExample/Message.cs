﻿using SQLite.Net.Attributes;

namespace SQLitePiExample {
    public class Message {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
