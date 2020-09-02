//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssConfig", SupportsShouldProcess = true, DefaultParameterSetName = "DefaultParameterSet")]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class NewAzureRmVmssConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        public bool? Overprovision { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Compute/virtualMachineScaleSets")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        [Alias("AccountType")]
        public string SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string SkuTier { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public int SkuCapacity { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public UpgradeMode? UpgradePolicyMode { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetNetworkConfiguration[] NetworkInterfaceConfiguration { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSetExtension[] Extension { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter SkipExtensionsOnOverprovisionedVMs { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public bool? SinglePlacementGroup { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter ZoneBalance { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int PlatformFaultDomainCount { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string[] Zone { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PlanName { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PlanPublisher { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PlanProduct { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PlanPromotionCode { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public RollingUpgradePolicy RollingUpgradePolicy { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public SwitchParameter EnableAutomaticRepair { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string AutomaticRepairGracePeriod { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter AutoOSUpgrade { get; set; }

        [Parameter(
            Mandatory = false)]
        public bool DisableAutoRollback { get; set; }

        [Parameter(
           Mandatory = false,
           ValueFromPipelineByPropertyName = true)]
        public SwitchParameter EnableUltraSSD { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string HealthProbeId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public BootDiagnostics BootDiagnostic { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string LicenseType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Regular", "Spot")]
        public string Priority { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Deallocate", "Delete")]
        public string EvictionPolicy { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public double MaxPrice { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public SwitchParameter TerminateScheduledEvents { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int TerminateScheduledEventNotBeforeTimeoutInMinutes { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string ProximityPlacementGroupId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Default", "OldestVM", "NewestVM")]
        public string[] ScaleInPolicy { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = "ExplicitIdentityParameterSet",
            ValueFromPipelineByPropertyName = true)]
        public ResourceIdentityType? IdentityType { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = "ExplicitIdentityParameterSet",
            ValueFromPipelineByPropertyName = true)]
        public string[] IdentityId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public SwitchParameter EncryptionAtHost { get; set; } 

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // Sku
            Sku vSku = null;

            // Plan
            Plan vPlan = null;

            // UpgradePolicy
            UpgradePolicy vUpgradePolicy = null;

            // AutomaticRepairsPolicy
            AutomaticRepairsPolicy vAutomaticRepairsPolicy = null;

            // VirtualMachineProfile
            PSVirtualMachineScaleSetVMProfile vVirtualMachineProfile = null;

            // ProximityPlacementGroup
            SubResource vProximityPlacementGroup = null;

            // AdditionalCapabilities
            AdditionalCapabilities vAdditionalCapabilities = null;

            // ScaleInPolicy
            ScaleInPolicy vScaleInPolicy = null;

            // Identity
            VirtualMachineScaleSetIdentity vIdentity = null;

            if (this.IsParameterBound(c => c.SkuName))
            {
                if (vSku == null)
                {
                    vSku = new Sku();
                }
                vSku.Name = this.SkuName;
            }

            if (this.IsParameterBound(c => c.SkuTier))
            {
                if (vSku == null)
                {
                    vSku = new Sku();
                }
                vSku.Tier = this.SkuTier;
            }

            if (this.IsParameterBound(c => c.SkuCapacity))
            {
                if (vSku == null)
                {
                    vSku = new Sku();
                }
                vSku.Capacity = this.SkuCapacity;
            }

            if (this.IsParameterBound(c => c.PlanName))
            {
                if (vPlan == null)
                {
                    vPlan = new Plan();
                }
                vPlan.Name = this.PlanName;
            }

            if (this.IsParameterBound(c => c.PlanPublisher))
            {
                if (vPlan == null)
                {
                    vPlan = new Plan();
                }
                vPlan.Publisher = this.PlanPublisher;
            }

            if (this.IsParameterBound(c => c.PlanProduct))
            {
                if (vPlan == null)
                {
                    vPlan = new Plan();
                }
                vPlan.Product = this.PlanProduct;
            }

            if (this.IsParameterBound(c => c.PlanPromotionCode))
            {
                if (vPlan == null)
                {
                    vPlan = new Plan();
                }
                vPlan.PromotionCode = this.PlanPromotionCode;
            }

            if (this.IsParameterBound(c => c.UpgradePolicyMode))
            {
                if (vUpgradePolicy == null)
                {
                    vUpgradePolicy = new UpgradePolicy();
                }
                vUpgradePolicy.Mode = this.UpgradePolicyMode;
            }

            if (this.IsParameterBound(c => c.RollingUpgradePolicy))
            {
                if (vUpgradePolicy == null)
                {
                    vUpgradePolicy = new UpgradePolicy();
                }
                vUpgradePolicy.RollingUpgradePolicy = this.RollingUpgradePolicy;
            }

            if (vUpgradePolicy == null)
            {
                vUpgradePolicy = new UpgradePolicy();
            }
            if (vUpgradePolicy.AutomaticOSUpgradePolicy == null)
            {
                vUpgradePolicy.AutomaticOSUpgradePolicy = new AutomaticOSUpgradePolicy();
            }
            vUpgradePolicy.AutomaticOSUpgradePolicy.EnableAutomaticOSUpgrade = this.AutoOSUpgrade.IsPresent;

            if (this.EnableAutomaticRepair.IsPresent)
            {
                if (vAutomaticRepairsPolicy == null)
                {
                    vAutomaticRepairsPolicy = new AutomaticRepairsPolicy();
                }
                vAutomaticRepairsPolicy.Enabled = this.EnableAutomaticRepair.IsPresent;
            }

            if (this.EncryptionAtHost.IsPresent)
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.SecurityProfile == null)
                {
                    vVirtualMachineProfile.SecurityProfile = new SecurityProfile();
                }
                vVirtualMachineProfile.SecurityProfile.EncryptionAtHost = this.EncryptionAtHost;
            }

            if (this.IsParameterBound(c => c.AutomaticRepairGracePeriod))
            {
                if (vAutomaticRepairsPolicy == null)
                {
                    vAutomaticRepairsPolicy = new AutomaticRepairsPolicy();
                }
                vAutomaticRepairsPolicy.GracePeriod = this.AutomaticRepairGracePeriod;
            }

            if (this.IsParameterBound(c => c.DisableAutoRollback))
            {
                if (vUpgradePolicy == null)
                {
                    vUpgradePolicy = new UpgradePolicy();
                }
                if (vUpgradePolicy.AutomaticOSUpgradePolicy == null)
                {
                    vUpgradePolicy.AutomaticOSUpgradePolicy = new AutomaticOSUpgradePolicy();
                }
                vUpgradePolicy.AutomaticOSUpgradePolicy.DisableAutomaticRollback = this.DisableAutoRollback;
            }

            if (this.IsParameterBound(c => c.OsProfile))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.OsProfile = this.OsProfile;
            }

            if (this.IsParameterBound(c => c.StorageProfile))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.StorageProfile = this.StorageProfile;
            }

            if (this.IsParameterBound(c => c.HealthProbeId))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.NetworkProfile == null)
                {
                    vVirtualMachineProfile.NetworkProfile = new VirtualMachineScaleSetNetworkProfile();
                }
                if (vVirtualMachineProfile.NetworkProfile.HealthProbe == null)
                {
                    vVirtualMachineProfile.NetworkProfile.HealthProbe = new ApiEntityReference();
                }
                vVirtualMachineProfile.NetworkProfile.HealthProbe.Id = this.HealthProbeId;
            }

            if (this.IsParameterBound(c => c.NetworkInterfaceConfiguration))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.NetworkProfile == null)
                {
                    vVirtualMachineProfile.NetworkProfile = new VirtualMachineScaleSetNetworkProfile();
                }
                vVirtualMachineProfile.NetworkProfile.NetworkInterfaceConfigurations = this.NetworkInterfaceConfiguration;
            }

            if (this.IsParameterBound(c => c.BootDiagnostic))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.DiagnosticsProfile == null)
                {
                    vVirtualMachineProfile.DiagnosticsProfile = new DiagnosticsProfile();
                }
                vVirtualMachineProfile.DiagnosticsProfile.BootDiagnostics = this.BootDiagnostic;
            }

            if (this.IsParameterBound(c => c.Extension))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.ExtensionProfile == null)
                {
                    vVirtualMachineProfile.ExtensionProfile = new PSVirtualMachineScaleSetExtensionProfile();
                }
                vVirtualMachineProfile.ExtensionProfile.Extensions = this.Extension;
            }

            if (this.IsParameterBound(c => c.LicenseType))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.LicenseType = this.LicenseType;
            }

            if (this.IsParameterBound(c => c.Priority))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.Priority = this.Priority;
            }

            if (this.IsParameterBound(c => c.EvictionPolicy))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.EvictionPolicy = this.EvictionPolicy;
            }

            if (this.IsParameterBound(c => c.MaxPrice))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.BillingProfile == null)
                {
                    vVirtualMachineProfile.BillingProfile = new BillingProfile();
                }
                vVirtualMachineProfile.BillingProfile.MaxPrice = this.MaxPrice;
            }

            if (this.TerminateScheduledEvents.IsPresent)
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.ScheduledEventsProfile == null)
                {
                    vVirtualMachineProfile.ScheduledEventsProfile = new ScheduledEventsProfile();
                }
                if (vVirtualMachineProfile.ScheduledEventsProfile.TerminateNotificationProfile == null)
                {
                    vVirtualMachineProfile.ScheduledEventsProfile.TerminateNotificationProfile = new TerminateNotificationProfile();
                }
                vVirtualMachineProfile.ScheduledEventsProfile.TerminateNotificationProfile.Enable = this.TerminateScheduledEvents.IsPresent;
            }

            if (this.IsParameterBound(c => c.TerminateScheduledEventNotBeforeTimeoutInMinutes))
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new PSVirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.ScheduledEventsProfile == null)
                {
                    vVirtualMachineProfile.ScheduledEventsProfile = new ScheduledEventsProfile();
                }
                if (vVirtualMachineProfile.ScheduledEventsProfile.TerminateNotificationProfile == null)
                {
                    vVirtualMachineProfile.ScheduledEventsProfile.TerminateNotificationProfile = new TerminateNotificationProfile();
                }
                vVirtualMachineProfile.ScheduledEventsProfile.TerminateNotificationProfile.NotBeforeTimeout = XmlConvert.ToString(new TimeSpan(0, this.TerminateScheduledEventNotBeforeTimeoutInMinutes, 0));
            }

            if (this.IsParameterBound(c => c.ProximityPlacementGroupId))
            {
                if (vProximityPlacementGroup == null)
                {
                    vProximityPlacementGroup = new SubResource();
                }
                vProximityPlacementGroup.Id = this.ProximityPlacementGroupId;
            }

            if (this.EnableUltraSSD.IsPresent)
            {
                if (vAdditionalCapabilities == null)
                {
                    vAdditionalCapabilities = new AdditionalCapabilities(true);
                }
            }

            if (this.IsParameterBound(c => c.ScaleInPolicy))
            {
                if (vScaleInPolicy == null)
                {
                    vScaleInPolicy = new ScaleInPolicy();
                }
                vScaleInPolicy.Rules = this.ScaleInPolicy;
            }

            if (this.IsParameterBound(c => c.IdentityType))
            {
                if (vIdentity == null)
                {
                    vIdentity = new VirtualMachineScaleSetIdentity();
                }
                vIdentity.Type = this.IdentityType;
            }

            if (this.IsParameterBound(c => c.IdentityId))
            {
                if (vIdentity == null)
                {
                    vIdentity = new VirtualMachineScaleSetIdentity();
                }

                vIdentity.UserAssignedIdentities = new Dictionary<string, VirtualMachineScaleSetIdentityUserAssignedIdentitiesValue>();

                foreach (var id in this.IdentityId)
                {
                    vIdentity.UserAssignedIdentities.Add(id, new VirtualMachineScaleSetIdentityUserAssignedIdentitiesValue());
                }
            }

            var vVirtualMachineScaleSet = new PSVirtualMachineScaleSet
            {
                Overprovision = this.IsParameterBound(c => c.Overprovision) ? this.Overprovision : (bool?)null,
                DoNotRunExtensionsOnOverprovisionedVMs = this.SkipExtensionsOnOverprovisionedVMs.IsPresent ? true : (bool?)null,
                SinglePlacementGroup = this.IsParameterBound(c => c.SinglePlacementGroup) ? this.SinglePlacementGroup : (bool?)null,
                ZoneBalance = this.ZoneBalance.IsPresent ? true : (bool?)null,
                PlatformFaultDomainCount = this.IsParameterBound(c => c.PlatformFaultDomainCount) ? this.PlatformFaultDomainCount : (int?)null,
                Zones = this.IsParameterBound(c => c.Zone) ? this.Zone : null,
                Location = this.IsParameterBound(c => c.Location) ? this.Location : null,
                Tags = this.IsParameterBound(c => c.Tag) ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                Sku = vSku,
                Plan = vPlan,
                UpgradePolicy = vUpgradePolicy,
                AutomaticRepairsPolicy = vAutomaticRepairsPolicy,
                VirtualMachineProfile = vVirtualMachineProfile,
                ProximityPlacementGroup = vProximityPlacementGroup,
                AdditionalCapabilities = vAdditionalCapabilities,
                ScaleInPolicy = vScaleInPolicy,
                Identity = vIdentity,
            };

            WriteObject(vVirtualMachineScaleSet);
        }
    }
}
