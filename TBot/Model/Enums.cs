﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tbot.Model
{
	public enum Classes
	{
		NoClass = 0,
		Collector = 1,
		General = 2,
		Discoverer = 3
	}

	public enum Celestials
	{
		Planet = 1,
		Debris = 2,
		Moon = 3,
		DeepSpace = 4
	}

	public enum Buildables
	{
		Null = 0,
		MetalMine = 1,
		CrystalMine = 2,
		DeuteriumSynthesizer = 3,
		SolarPlant = 4,
		FusionReactor = 12,
		MetalStorage = 22,
		CrystalStorage = 23,
		DeuteriumTank = 24,
		ShieldedMetalDen = 25,
		UndergroundCrystalDen = 26,
		SeabedDeuteriumDen = 27,
		AllianceDepot = 34,
		RoboticsFactory = 14,
		Shipyard = 21,
		ResearchLab = 31,
		MissileSilo = 44,
		NaniteFactory = 15,
		Terraformer = 33,
		SpaceDock = 36,
		LunarBase = 41,
		SensorPhalanx = 42,
		JumpGate = 43,
		RocketLauncher = 401,
		LightLaser = 402,
		HeavyLaser = 403,
		GaussCannon = 404,
		IonCannon = 405,
		PlasmaTurret = 406,
		SmallShieldDome = 407,
		LargeShieldDome = 408,
		AntiBallisticMissiles = 502,
		InterplanetaryMissiles = 503,
		SmallCargo = 202,
		LargeCargo = 203,
		LightFighter = 204,
		HeavyFighter = 205,
		Cruiser = 206,
		Battleship = 207,
		ColonyShip = 208,
		Recycler = 209,
		EspionageProbe = 210,
		Bomber = 211,
		SolarSatellite = 212,
		Destroyer = 213,
		Deathstar = 214,
		Battlecruiser = 215,
		Crawler = 217,
		Reaper = 218,
		Pathfinder = 219,
		EspionageTechnology = 106,
		ComputerTechnology = 108,
		WeaponsTechnology = 109,
		ShieldingTechnology = 110,
		ArmourTechnology = 111,
		EnergyTechnology = 113,
		HyperspaceTechnology = 114,
		CombustionDrive = 115,
		ImpulseDrive = 117,
		HyperspaceDrive = 118,
		LaserTechnology = 120,
		IonTechnology = 121,
		PlasmaTechnology = 122,
		IntergalacticResearchNetwork = 123,
		Astrophysics = 124,
		GravitonTechnology = 199
	}

	public enum Missions
	{
		Attack = 1,
		FederalAttack = 2,
		Transport = 3,
		Deploy = 4,
		FederalDefense = 5,
		Spy = 6,
		Colonize = 7,
		Harvest = 8,
		Destroy = 9,
		MissileAttack = 10,
		Expedition = 15,
		Trade = 16
	}

	public enum Speeds
	{
		TenPercent = 1,
		TwentyPercent = 2,
		ThirtyPercent = 3,
		FourtyPercent = 4,
		FiftyPercent = 5,
		SixtyPercent = 6,
		SeventyPercent = 7,
		EightyPercent = 8,
		NinetyPercent = 9,
		HundredPercent = 10
	}

	public enum Percents
	{
		TenPercent = 10,
		TwentyPercent = 20,
		ThirtyPercent = 30,
		FourtyPercent = 40,
		FiftyPercent = 50,
		SixtyPercent = 60,
		SeventyPercent = 70,
		EightyPercent = 80,
		NinetyPercent = 90,
		HundredPercent = 100
	}

	public enum IntervalType
	{
		LessThanASecond,
		AFewSeconds,
		SomeSeconds,
		AMinuteOrTwo,
		AboutFiveMinutes,
		AboutTenMinutes,
		AboutAQuarterHour,
		AboutHalfAnHour,
		AboutAnHour
	}

	public enum UpdateType
	{
		Fast,
		Full,
		Resources,
		Buildings,
		Ships,
		Facilities,
		Defences,
		Productions,
		Constructions,
		ResourceSettings,
		ResourceProduction
	}

	public enum LogType
	{
		Info,
		Debug,
		Warning,
		Error
	}

	public enum LogSender
	{
		Tbot,
		Defender,
		Brain,
		Expeditions,
		Harvest
	}

	public enum Feature
	{
		Defender = 0,
		BrainAutobuildCargo = 1,
		BrainAutoRepatriate = 2,
		BrainAutoMine = 3,
		Expeditions = 4,
		Harvest = 5
	}
}
