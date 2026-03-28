// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

using System.Text.Json.Serialization;

namespace em_wtm.Model._Business.Report.dockModel {

    /// <summary>
    /// DockComponent 基类
    /// </summary>
    public abstract class DockComponentBase {
        /// <summary>
        /// 获得/设置 默认 Component
        /// </summary>
        public DockContentType Type { get; set; }

        /// <summary>
        /// 获得/设置 DockContent 实例
        /// </summary>
        private DockContent? Content { get; set; }

    }
}
