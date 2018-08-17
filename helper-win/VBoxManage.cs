// A Hello World! program in C#.
using System;
namespace HelloWorld
{
	class Hello 
	{
		static void Main(string[] args) 
		{
			if (args.Length == 3 && args[0] == "showvminfo" && args[2] == "--machinereadable")
			{
				Console.WriteLine(@"
name=""Sailfish OS Build Engine""
groups=""/""
ostype=""Linux 2.6 / 3.x / 4.x (32-bit)""
UUID=""5bc88aa7-3372-4122-9d67-52b62310fdc4""
CfgFile=""C:\\SailfishOS\\mersdk\\Sailfish OS Build Engine\\Sailfish OS Build Engine.vbox""
SnapFldr=""C:\\SailfishOS\\mersdk\\Sailfish OS Build Engine\\Snapshots""
LogFldr=""C:\\SailfishOS\\mersdk\\Sailfish OS Build Engine\\Logs""
hardwareuuid=""5bc88aa7-3372-4122-9d67-52b62310fdc4""
memory=8192
pagefusion=""off""
vram=10
cpuexecutioncap=100
hpet=""off""
chipset=""piix3""
firmware=""BIOS""
cpus=6
pae=""on""
longmode=""on""
triplefaultreset=""off""
apic=""on""
x2apic=""off""
cpuid-portability-level=0
bootmenu=""messageandmenu""
boot1=""disk""
boot2=""none""
boot3=""none""
boot4=""none""
acpi=""on""
ioapic=""on""
biosapic=""apic""
biossystemtimeoffset=0
rtcuseutc=""off""
hwvirtex=""on""
nestedpaging=""on""
largepages=""on""
vtxvpid=""on""
vtxux=""on""
paravirtprovider=""default""
effparavirtprovider=""kvm""
VMState=""poweroff""
VMStateChangeTime=""2018-08-14T19:59:17.000000000""
monitorcount=1
accelerate3d=""off""
accelerate2dvideo=""off""
teleporterenabled=""off""
teleporterport=0
teleporteraddress=""""
teleporterpassword=""""
tracing-enabled=""off""
tracing-allow-vm-access=""off""
tracing-config=""""
autostart-enabled=""off""
autostart-delay=0
defaultfrontend=""""
storagecontrollername0=""SATA""
storagecontrollertype0=""IntelAhci""
storagecontrollerinstance0=""0""
storagecontrollermaxportcount0=""30""
storagecontrollerportcount0=""2""
storagecontrollerbootable0=""on""
""SATA-0-0""=""none""
""SATA-1-0""=""C:\SailfishOS\mersdk\mer.vdi""
""SATA-ImageUUID-1-0""=""9d8a6b7b-118a-4657-9d69-656ab6f3967f""
natnet1=""nat""
macaddress1=""080027F21001""
cableconnected1=""on""
nic1=""nat""
nictype1=""virtio""
nicspeed1=""0""
mtu=""0""
sockSnd=""64""
sockRcv=""64""
tcpWndSnd=""64""
tcpWndRcv=""64""
Forwarding(0)=""guestssh,tcp,127.0.0.1,2222,,22""
Forwarding(1)=""guestwww,tcp,127.0.0.1,8080,,9292""
intnet2=""SailfishOS-SDK""
macaddress2=""08005A11F155""
cableconnected2=""on""
nic2=""intnet""
nictype2=""virtio""
nicspeed2=""0""
nic3=""none""
nic4=""none""
nic5=""none""
nic6=""none""
nic7=""none""
nic8=""none""
hidpointing=""ps2mouse""
hidkeyboard=""ps2kbd""
uart1=""off""
uart2=""off""
uart3=""off""
uart4=""off""
lpt1=""off""
lpt2=""off""
audio=""dsound""
audio_in=""false""
audio_out=""false""
clipboard=""disabled""
draganddrop=""disabled""
vrde=""off""
usb=""off""
ehci=""off""
xhci=""off""
SharedFolderNameMachineMapping1=""home""
SharedFolderPathMachineMapping1=""C:/Users/coderus""
SharedFolderNameMachineMapping2=""targets""
SharedFolderPathMachineMapping2=""C:\SailfishOS/mersdk/targets""
SharedFolderNameMachineMapping3=""ssh""
SharedFolderPathMachineMapping3=""C:\SailfishOS/mersdk/ssh""
SharedFolderNameMachineMapping4=""config""
SharedFolderPathMachineMapping4=""C:\SailfishOS/vmshare""
SharedFolderNameMachineMapping5=""src1""
SharedFolderPathMachineMapping5=""C:/Users/coderus""
videocap=""off""
videocap_audio=""off""
videocapscreens=0
videocapfile=""C:\SailfishOS\mersdk\Sailfish OS Build Engine\Sailfish OS Build Engine.webm""
videocapres=1024x768
videocaprate=512
videocapfps=25
videocapopts=ac_enabled=false
GuestMemoryBalloon=0
SessionType=""headless""
					");
			}
			else if (args.Length == 2 && args[0] == "showvminfo")
			{
				Console.WriteLine(@"
Name:            Sailfish OS Build Engine
Groups:          /
Guest OS:        Linux 2.6 / 3.x / 4.x (32-bit)
UUID:            5bc88aa7-3372-4122-9d67-52b62310fdc4
Config file:     C:\SailfishOS\mersdk\Sailfish OS Build Engine\Sailfish OS Build Engine.vbox
Snapshot folder: C:\SailfishOS\mersdk\Sailfish OS Build Engine\Snapshots
Log folder:      C:\SailfishOS\mersdk\Sailfish OS Build Engine\Logs
Hardware UUID:   5bc88aa7-3372-4122-9d67-52b62310fdc4
Memory size:     8192MB
Page Fusion:     off
VRAM size:       10MB
CPU exec cap:    100%
HPET:            off
Chipset:         piix3
Firmware:        BIOS
Number of CPUs:  6
PAE:             on
Long Mode:       on
Triple Fault Reset: off
APIC:            on
X2APIC:          off
CPUID Portability Level: 0
CPUID overrides: None
Boot menu mode:  message and menu
Boot Device (1): HardDisk
Boot Device (2): Not Assigned
Boot Device (3): Not Assigned
Boot Device (4): Not Assigned
ACPI:            on
IOAPIC:          on
BIOS APIC mode:  APIC
Time offset:     0ms
RTC:             local time
Hardw. virt.ext: on
Nested Paging:   on
Large Pages:     on
VT-x VPID:       on
VT-x unr. exec.: on
Paravirt. Provider: Default
Effective Paravirt. Provider: KVM
State:           powered off (since 2018-08-14T19:59:17.000000000)
Monitor count:   1
3D Acceleration: off
2D Video Acceleration: off
Teleporter Enabled: off
Teleporter Port: 0
Teleporter Address:
Teleporter Password:
Tracing Enabled: off
Allow Tracing to Access VM: off
Tracing Configuration:
Autostart Enabled: off
Autostart Delay: 0
Default Frontend:
Storage Controller Name (0):            SATA
Storage Controller Type (0):            IntelAhci
Storage Controller Instance Number (0): 0
Storage Controller Max Port Count (0):  30
Storage Controller Port Count (0):      2
Storage Controller Bootable (0):        on
SATA (1, 0): C:\SailfishOS\mersdk\mer.vdi (UUID: 9d8a6b7b-118a-4657-9d69-656ab6f3967f)
NIC 1:           MAC: 080027F21001, Attachment: NAT, Cable connected: on, Trace: off (file: none), Type: virtio, Reported speed: 0 Mbps, Boot priority: 0, Promisc Policy: deny, Bandwidth group: none
NIC 1 Settings:  MTU: 0, Socket (send: 64, receive: 64), TCP Window (send:64, receive: 64)
NIC 1 Rule(0):   name = guestssh, protocol = tcp, host ip = 127.0.0.1, host port = 2222, guest ip = , guest port = 22
NIC 1 Rule(1):   name = guestwww, protocol = tcp, host ip = 127.0.0.1, host port = 8080, guest ip = , guest port = 9292
NIC 2:           MAC: 08005A11F155, Attachment: Internal Network 'SailfishOS-SDK', Cable connected: on, Trace: off (file: none), Type: virtio, Reported speed: 0 Mbps, Boot priority: 0, Promisc Policy: deny, Bandwidth group: none
NIC 3:           disabled
NIC 4:           disabled
NIC 5:           disabled
NIC 6:           disabled
NIC 7:           disabled
NIC 8:           disabled
Pointing Device: PS/2 Mouse
Keyboard Device: PS/2 Keyboard
UART 1:          disabled
UART 2:          disabled
UART 3:          disabled
UART 4:          disabled
LPT 1:           disabled
LPT 2:           disabled
Audio:           enabled (Driver: DSOUND, Controller: AC97, Codec: STAC9700)
Audio playback:  disabled
Audio capture: disabled
Clipboard Mode:  disabled
Drag and drop Mode: disabled
VRDE:            disabled
USB:             disabled
EHCI:            disabled
XHCI:            disabled

USB Device Filters:

<none>

Bandwidth groups: <none>

Shared folders:

Name: 'home', Host path: 'C:/Users/coderus' (machine mapping), writable
Name: 'targets', Host path: 'C:\SailfishOS/mersdk/targets' (machine mapping), writable
Name: 'ssh', Host path: 'C:\SailfishOS/mersdk/ssh' (machine mapping), readonly
Name: 'config', Host path: 'C:\SailfishOS/vmshare' (machine mapping), readonly
Name: 'src1', Host path: 'C:/Users/coderus' (machine mapping), writable

Capturing:          not active
Capture audio:      not active
Capture screens:    0
Capture file:       C:\SailfishOS\mersdk\Sailfish OS Build Engine\Sailfish OS Build Engine.webm
Capture dimensions: 1024x768
Capture rate:       512 kbps
Capture FPS:        25
Capture options:    ac_enabled=false

Guest:

Configured memory balloon size:      0 MB

Session name: headless

					");
			}
		}
	}
}