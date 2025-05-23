/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 * All rights reserved.
 *
 * Licensed under the Oculus SDK License Agreement (the "License");
 * you may not use the Oculus SDK except in compliance with the License,
 * which is provided at the time of installation or download, or which
 * otherwise accompanies this software in either electronic or hard copy form.
 *
 * You may obtain a copy of the License at
 *
 * https://developer.oculus.com/licenses/oculussdk/
 *
 * Unless required by applicable law or agreed to in writing, the Oculus SDK
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using Meta.Voice.TelemetryUtilities;
using Meta.WitAi;
using Meta.WitAi.Windows;
using UnityEngine;
using Oculus.Voice.Utility;
using Oculus.Voice.Inspectors;

namespace Oculus.Voice.Windows
{
    public class UnderstandingViewerWindow : WitUnderstandingViewer
    {
        protected override GUIContent Title => VoiceSDKStyles.UnderstandingTitle;
        protected override Texture2D HeaderIcon => VoiceSDKStyles.MainHeader;
        protected override string HeaderUrl => AppVoiceExperienceWitConfigurationEditor.GetSafeAppUrl(witConfiguration, WitTexts.WitAppEndpointType.Understanding);
        protected override string DocsUrl => VoiceSDKStyles.Texts.VoiceDocsUrl;

        protected override void OnEnable()
        {
            Telemetry.Editor.LogInstantEvent(EditorTelemetry.TelemetryEventId.OpenUi, new Dictionary<EditorTelemetry.AnnotationKey, string>()
            {
                {EditorTelemetry.AnnotationKey.PageId, "Configuration Window"}
            });
            base.OnEnable();
        }
    }
}
