/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [productID]
      ,[cost]
      ,[manufacturer]
      ,[model]
      ,[RAM_type]
      ,[RAM_size]
      ,[displaytype]
      ,[screensize]
      ,[resolution]
      ,[CPU_Class]
      ,[CPU_brand]
      ,[CPU_type]
      ,[CPU_speed]
      ,[CPU_number]
      ,[condition]
      ,[OS]
      ,[platform]
      ,[HDD_size]
      ,[HDD_speed]
      ,[GPU_Type]
      ,[optical_drive]
      ,[Audio_type]
      ,[LAN]
      ,[WIFI]
      ,[width]
      ,[height]
      ,[depth]
      ,[weight]
      ,[moust_type]
      ,[power]
      ,[webcam]
  FROM [DollarComputers].[dbo].[products]