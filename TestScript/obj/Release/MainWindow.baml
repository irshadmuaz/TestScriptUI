   M S B A M L   `   `   `  ���� E  ATestScript, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TestScript
TestScript      TestScript.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TestScript       � Title$  
MainWindow��$��536.667��$��979.333��
������� � DataContext    TestScript.DisplayOutput  .���� $
��Auto=�$
��Auto=�.��� -    �Name$ mainApp��$	��927�� � ColumnDefinitions �� $��20 ��� $��61.167 ��� $��387.5 ��� $	��54* �$	��400���� $
��347* � � RowDefinitions �� $��20 ��� $
��Auto ��� $
��Auto ��� $��* �.+�]� $��5,5,4.667,5q�$��1��$��1����.  $��2��.+��� $��Serial port��
�������
���   ��� -    ��Name$ portbox��$	��120���� -    ��Name$ Connect��$��Connect�����	#FF080517���	#FF54ABFC$��5q���  �� Orientation$ 
Horizontal=�$��3��$��1��$��2��$��0.333,0,-0.333,0q�.+�	� -    	�Name$
 Core��$��ACT LGA��$��5,10,5,0q�$
��Bold"�	 	� 	GroupName$
	 Core��
 d� 	IsChecked$

 TrueY�	� -   $ Core2��$	��C2+��$��5,10,5,0q�$
��Bold"�$
	 Core���� -    ��Name$ output��$��3��$��2�����	#FF030303
�������$��10.166,36,10.834,50q�$
��Auto=�$
��Auto=�$��2��$	��362������ *value+�� $��1��$��2��$	��388��$��10,10,9.667,50.333q�$��2��.@��� $	��ARM��.���� $	��350��.���� -    ��Name$ s1��$��1��$��1��$	��388��$��0,0,1,0q�.+��� 
���   �$��1q�$��1��$��0,0,-0.333,0q�]� $��5q���. 
�������.+��� $��	FVT TESTS��$��Center=�$��Gill Sans MT)�$
��Bold"�$��Italic$�]� $��5q����	#FFEBF2EA.+��� $��LPDDR���� -   $ lpddr_dataline��$��Dataline��$��Right=�$��50�����	#FFC4E59C$��5q��� -	   $ lpddr_addrline��$��Addrline��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $
��NAND���� -
   $ nand_partition��$��	Partition��$��Right=�$��50�����	#FFC4E59C$��5q��� -   $ 	nand_scan��$
��Scan��$��Right=�$��50�����	#FFC4E59C$��5q��� -   $ 
nand_probe��$��Probe��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $	��USB���� -   $	 usb��$��Autotest��$��Right=�$��90�����	#FFC4E59C�� $�� ��]� $��5q����	#FFEBF2EA.+��� $	��I2C���� -   $ i2c_02��$��I2C0 to I2C2��$��Right=�$��50�����	#FFC4E59C$��5q��� -   $ i2c_12��$��I2C1 to I2C2��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $	��SPI���� -   $	 spi��$��SPI2_slave SPI1_master��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $
��GPIO���� -   $ gpio_loopback��$��Loopback��$��Right=�$��50�����	#FFC4E59C$��5q�$	��101���� -   $ gpio_wz��$��Walking zero��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $��BBURAM���� -   $ bburam_write��$��Write��$��Right=�$��50�����	#FFC4E59C$��5q��� -   $ 	bburam_dv��$��Data verify��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $	��OTP���� -   $ otp_assm_read��$��Assm rd��$��Right=�$��30�����	#FFC4E59C$��5q��� -   $ otp_assm_write��$��Assm wr��$��Right=�$��30�����	#FFC4E59C$��5q��� -   $ otp_id_read��$��Id rd��$��Right=�$��30�����	#FFC4E59C$��5q��� -   $ otp_id_write��$��Id wr��$��Right=�$��30�����	#FFC4E59C$��5q��� -   $ otp_cal_read��$��Cal rd��$��Right=�$��30�����	#FFC4E59C$��5q��� -   $ otp_cal_write��$��Cal wr��$��Right=�$��30�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $
��UART���� -   $ uart3lb��$��
3 Loopback��$��Right=�$��50�����	#FFC4E59C$��5q��� -   $ uart12��$��1,2 Loopback��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $
��SDIO���� -   $ sdio0��$��
Autotest 0��$��Right=�$��50�����	#FFC4E59C$��5q��� -   $ sdio1��$��
Autotest 1��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $	��ADC���� -   $
 adc5��$��5��$��Right=�$��30�����	#FFC4E59C$��5q��� -    $
 adc4��$��4��$��Right=�$��30�����	#FFC4E59C$��5q��� -!   $
 adc3��$��3��$��Right=�$��30�����	#FFC4E59C$��5q��� -"   $
 adc2��$��2��$��Right=�$��30�����	#FFC4E59C$��5q��� -#   $
 adc1��$��1��$��Right=�$��30�����	#FFC4E59C$��5q��� -$   $
 adc0��$��0��$��Right=�$��30�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $��Accelerometer���� -%   $ accel_getid��$��Get id��$��Right=�$��30�����	#FFC4E59C$��5q��� -&   $ 
accel_read��$��Read raw��$��Right=�$��30�����	#FFC4E59C$��5q��� -'   $ accel_check��$��Check��$��Right=�$��30�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $
��IPM2���� -(   $ ipm_rf_enable��$��Rf on��$��Right=�$��30�����	#FFC4E59C$��5q��� -)   $ ipm_ldo_disable��$��ldo off��$��Right=�$��30�����	#FFC4E59C$��5q��� -*   $ ipm_ldo_enable��$��ldo on��$��Right=�$��30�����	#FFC4E59C$��5q��� -+   $ ipm_lcd_disable��$��lcd off��$��Right=�$��30�����	#FFC4E59C$��5q��� -,   $ ipm_lcd_enable��$��lcd on��$��Right=�$��30�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $
��IPM2���� --   $ ipm_battMeasure��$��Measure��$��Right=�$��30�����	#FFC4E59C$��5q��� -.   $ ipm_battDis��$��BattDis��$��Right=�$��30�����	#FFC4E59C$��5q��� -/   $ 
ipm_battEn��$��BattEn��$��Right=�$��30�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $��IPM2 ���� -0   $ 	ipm_clear��$��Clear��$��Right=�$��30�����	#FFC4E59C$��5q��� -1   $ ipm_read��$
��Read��$��Right=�$��30�����	#FFC4E59C$��5q��� -2   $ ipm_powerup��$��PowerUp��$��Right=�$��30�����	#FFC4E59C$��5q��� -3   $ ipm_powerdn��$��PowerDn��$��Right=�$��30�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $��IPM2Rmt���� -4   $ 
ipm_rdopen��$��Rdopen��$��Right=�$��30�����	#FFC4E59C$��5q��� -5   $ ipm_vrdDisable��$��VrdDis��$��Right=�$��30�����	#FFC4E59C$��5q��� -6   $ ipm_vrdEnable��$��VrdEn��$��Right=�$��30�����	#FFC4E59C$��5q��� -7   $ ipm_rdsRecharge��$��	Rechgarge��$��Right=�$��30�����	#FFC4E59C$��5q��� -8   $ ipm_rdsClose��$��RdsClose��$��Right=�$��30�����	#FFC4E59C$��5q��� $�� ���� $��RF��.���� $��1��$��1��$	��388��$��0,0,0.667,0.333q�����  �� ElementName$ s1�� �� Path$ ActualWidth�.+��� 
���   �$��1q�$��1��$��0,0,-0.333,0q�]� $��5q���. 
�������.+��� $��	FVT TESTS��$��Center=�$��Gill Sans MT)�$
��Bold"�$��Italic$�]� $��5q����	#FFEBF2EA.+��� $
��GPIO���� -9   $ rfgpio_loopback��$��Loopback��$��Right=�$��50�����	#FFC4E59C$��5q�$	��101���� -:   $ 	rfgpio_wz��$��Walking zero��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��]� $��5q����	#FFEBF2EA.+��� $	��ADC���� -;   $ rfadc5��$��5��$��Right=�$��30�����	#FFC4E59C$��5q��� -<   $ rfadc4��$��4��$��Right=�$��30�����	#FFC4E59C$��5q��� -=   $ rfadc3��$��3��$��Right=�$��30�����	#FFC4E59C$��5q��� ->   $ rfadc2��$��2��$��Right=�$��30�����	#FFC4E59C$��5q��� -?   $ rfadc1��$��1��$��Right=�$��30�����	#FFC4E59C$��5q��� -@   $ rfadc0��$��0��$��Right=�$��30�����	#FFC4E59C$��5q��� $�� ���� $	��PLC��.���� $��1��$��1��$	��388��$��0,0,-0.333,0.333q����� $ s1��$ ActualWidth�.+��� 
���   �$��1q�$��1��$��0,0,-0.333,0q�]� $��5q���. 
�������.+��� $��	FVT TESTS��$��Center=�$��Gill Sans MT)�$
��Bold"�$��Italic$�]� $��5q����	#FFEBF2EA.+��� $
��GPIO���� -A   $ plcgpio_loopback��$��Loopback��$��Right=�$��50�����	#FFC4E59C$��5q�$	��101���� -B   $ 
plcgpio_wz��$��Walking zero��$��Right=�$��50�����	#FFC4E59C$��5q��� $�� ��