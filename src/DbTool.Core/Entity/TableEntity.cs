﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeihanLi.Extensions;

namespace DbTool.Core.Entity
{
    /// <summary>
    /// 表信息
    /// </summary>
    public class TableEntity
    {
        /// <summary>
        /// 表名称
        /// </summary>
        [Required]
        public string TableName { get => _tableName; set => _tableName = value?.Trim(); }

        private string _tableName;
        private List<ColumnEntity> _columns;

        /// <summary>
        /// 表描述
        /// </summary>
        public string TableDescription { get; set; }

        /// <summary>
        /// 获取描述信息，如果描述信息为空则返回列名
        /// </summary>
        public string GetNotEmptyDescription() => TableDescription.GetValueOrDefault(_tableName);

        /// <summary>
        /// 表架构 scheme
        /// </summary>
        public string TableSchema { get; set; }

        /// <summary>
        /// 列信息
        /// </summary>
        public List<ColumnEntity> Columns
        {
            get => _columns;
            set
            {
                if (value != null)
                {
                    _columns = value;
                }
            }
        }

        public TableEntity()
        {
            Columns = new List<ColumnEntity>();
        }
    }
}
