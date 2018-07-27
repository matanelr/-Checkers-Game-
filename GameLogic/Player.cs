﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Player
    {
        public enum eShapeType
        {
            X,
            O,
        }

        public enum ePlayerType
        {
            Person,
            Computer,
        }

        private string m_PlayerName;
        private eShapeType m_Shape;
        private ePlayerType m_PlayerType;
        private bool v_JumpTurn;
        private int m_Points;

        public Player(eShapeType shape, string PlayerName, ePlayerType i_PlayerType)
        {
            this.m_Shape = shape;
            this.m_PlayerName = PlayerName;
            v_JumpTurn = false;
            this.m_PlayerType = i_PlayerType;
            this.m_Points = 0;
        }

        internal ePlayerType PlayerType
        {
            get
            {
                return this.m_PlayerType;
            }

            set
            {
                m_PlayerType = value;
            }
        }

        public int Points
        {
            get
            {
                return this.m_Points;
            }

            set
            {
                m_Points = value;
            }
        }

        internal bool IsJumpTurn
        {
            get
            {
                return this.v_JumpTurn;
            }

            set
            {
                v_JumpTurn = value;
            }
        }

        public string Name
        {
            get
            {
                return this.m_PlayerName;
            }
            set
            {
                this.Name = value;
            }
        }

        internal eShapeType GetShapeType()
        {
            return this.m_Shape;
        }
    }
}

